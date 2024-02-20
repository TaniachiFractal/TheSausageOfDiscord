using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaslovaT_task6_practice2024
{
    public partial class TheSausageOfDiscord : Form
    {
        /// <summary>
        /// Данные игрока
        /// </summary>
        CrowPlayer playerCrow = new CrowPlayer();
        /// <summary>
        /// Данные врага
        /// </summary>
        CatEnemy enemyCat = new CatEnemy();

        /// <summary>
        /// Данные полоски здоровья вороны-игрока
        /// </summary>
        HPbar crowHP = new HPbar();
        /// <summary>
        /// Данные полоски здоровья кошки-врага
        /// </summary>
        HPbar catHP = new HPbar();

        public TheSausageOfDiscord()
        {
            InitializeComponent();
        }

       
        /// <summary>
        /// Загрузка игры
        /// </summary>
        private void TheSausageOfDiscord_Load(object sender, EventArgs e)
        {           
            whatsGoingOn_helpProviderPopup newForm = new whatsGoingOn_helpProviderPopup();
            newForm.ShowDialog();
            WriteLn(" ");
        }

        /// <summary>
        /// Показать окошко с объяснением игры
        /// </summary>
        private void BtHelp_Click(object sender, EventArgs e)
        {
            whatsGoingOn_helpProviderPopup newForm = new whatsGoingOn_helpProviderPopup();
            newForm.ShowDialog();
        }
  

        #region Всплывающие подсказки атак
        private void BtPeck_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(btPeck, "Нанести врагу урон в 1/5 его HP");
        }
        private void BtGetRock_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(btGetRock, "Взять камень.");
        }
        private void BtThrowRock_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(btThrowRock, "Бросить камень, если он взят. Нанесёт врагу урон в 3/5 его HP");
        }
        private void btRetreat_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(btRetreat, "Сесть на ветку, чтобы уклониться от атаки, и скушать рябины, которая восстановит 1/5 HP");
        }
        private void btScream_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(btScream, "Каркнуть и напугать врага. Снизит его урон на 1/10");
        }
        #endregion

        #region Атаки
        /// <summary>
        /// Базовая атака: урон 1/5 HP = 20
        /// </summary>
        private void BtPeck_Click(object sender, EventArgs e)
        {
            WriteLn("Ворона клюнула кошку!");
            enemyCat.HP -= 20;
            catHP.HP = enemyCat.HP;
            RedrawHPbar(HPbarCat, catHP);
            CatAttacks();
            WriteLn(" ");
        }
        /// <summary>
        /// Взять камень и пропустить ход
        /// </summary>
        private void BtGetRock_Click(object sender, EventArgs e)
        {
            WriteLn("Ворона нашла камень.");
            playerCrow.hasRock = true;
            CatAttacks();
            WriteLn(" ");
        }
        /// <summary>
        /// Сильная атака: урон 3/5 HP = 60; Требует взять камень
        /// </summary>
        private void BtThrowRock_Click(object sender, EventArgs e)
        {
            if (playerCrow.hasRock)
            {
                WriteLn("Ворона бросила камень в кошку!!!");
                playerCrow.hasRock = false;
                enemyCat.HP -= 60;
                catHP.HP = enemyCat.HP;
                RedrawHPbar(HPbarCat, catHP);
            }
            else
            {
                WriteLn("Ворона не может бросить камень, если его у неё нет!");
            }
            CatAttacks();
            WriteLn(" ");
        }
        /// <summary>
        /// Понизить урон кошки на 1/10 = 2
        /// </summary>
        private void BtScream_Click(object sender, EventArgs e)
        {
            WriteLn("Ворона каркнула! Урон кошки понизился");
            enemyCat.attack -= 2;
            CatAttacks();
            WriteLn(" ");
        }
        /// <summary>
        /// Уклониться от атаки и восстановить здоровье на 1/5 = 20
        /// </summary>
        private void BtRetreat_Click(object sender, EventArgs e)
        {
            WriteLn("Ворона села на рябину и поела её!");
            WriteLn("Кошка промахнулась");
            if (playerCrow.HP<80)
            {
                playerCrow.HP += 20;
            }
            else
            {
                playerCrow.HP = 100;
            }
            crowHP.HP = playerCrow.HP;
            RedrawHPbar(HPbarCrow, crowHP);

            WriteLn(" ");
        }
        #endregion

        //////////////////////////////////
   
        /// <summary>
        /// Кошка наносит урон вороне
        /// </summary>
        public void CatAttacks()
        {
            WriteLn("Кошка царапнула ворону!");
            playerCrow.HP -= 22;
            crowHP.HP = playerCrow.HP;
            RedrawHPbar(HPbarCrow, crowHP);
            CheckIfToEnd();
        }

        /// <summary>
        /// Проверка окончания игры
        /// </summary>
        public void CheckIfToEnd()
        {
            if(enemyCat.HP<1)
            {
                endingYouWon win = new endingYouWon();
                win.ShowDialog();
                this.Close();
            }
            else if(playerCrow.HP<1)
            {
                endingYouLost loss = new endingYouLost();
                loss.ShowDialog();
                this.Close();
            }
        }

        /// <summary>
        /// Перерисовать полоску здоровья 
        /// </summary>
        public void RedrawHPbar(PictureBox HPpicBox, HPbar hpBar)
        {
            if(hpBar.HP * 1.98 < 198)
                HPpicBox.Width =(int)(hpBar.HP*1.98);
            hpBar.updateBarColor();
            HPpicBox.BackColor = hpBar.barColor;
        }

        /// <summary>
        /// Вывод текста в консоль с переносом строки
        /// </summary>
        void WriteLn(string input)
        {
            tbMainConsole.Text += Environment.NewLine + input;
        }

        
    }

}
