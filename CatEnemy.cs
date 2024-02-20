
namespace MaslovaT_task6_practice2024
{
    /// <summary>
    /// Класс данных врага
    /// </summary>
    class CatEnemy
    {
        /// <summary>
        /// Здоровье врага
        /// </summary>
        public int HP;
        /// <summary>
        /// Атака кошки. Её можно понижать карканьем
        /// </summary>
        public int attack;
         /// <summary>
         /// Базовый конструктор
         /// </summary>
        public CatEnemy()
        {
            HP = 100;
            attack = 20;
        }
    }
}
