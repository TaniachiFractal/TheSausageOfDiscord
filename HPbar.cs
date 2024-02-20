using System.Drawing;

namespace MaslovaT_task6_practice2024
{
    /// <summary>
    /// Рендер полосок здоровья
    /// </summary>
    public class HPbar
    {
        #region цвета здоровья
        static public Color goodHP = Color.LightGreen;
        static public Color midHP = Color.Gold;
        static public Color badHP = Color.OrangeRed;
        #endregion

        /// <summary>
        /// Здоровье
        /// </summary>
        public int HP;

        /// <summary>
        /// Цвет полоски здоровья
        /// </summary>
        public Color barColor;

        /// <summary>
        /// Базовый конструктор
        /// </summary>
        public HPbar()
        {
            HP = 100;
            barColor = goodHP;
        }
        /// <summary>
        /// Поменять цвет полоски в зависимости от здоровья
        /// </summary>
        public void updateBarColor()
        {
            if (HP > 50)
            {
                barColor = goodHP;
            }
            else if (HP > 20)
            {
                barColor = midHP;
            }
            else
            {
                barColor = badHP;
            }
        }

    }
}
