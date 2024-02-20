
namespace MaslovaT_task6_practice2024
{
    /// <summary>
    /// Класс данных игрока
    /// </summary>
    class CrowPlayer
    {
        /// <summary>
        /// Если у вороны есть камень, она может его бросить. Если нет - то не может
        /// </summary>
        public bool hasRock;
        /// <summary>
        /// Здоровье игрока
        /// </summary>
        public int HP;      
        /// <summary>
        /// Базовый конструктор
        /// </summary>
        public CrowPlayer()
        {
            hasRock = false; HP = 100;
        }
    }
}
