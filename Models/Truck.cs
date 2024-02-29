namespace TekhnikaSite.Models
{
    public class Truck
    {
        public int Id { get; set; } // Уникальный идентификатор грузовика
        public string Model { get; set; } // Модель грузовика
        public string Make { get; set; } // Марка грузовика
        public int Year { get; set; } // Год выпуска
        public string Description { get; set; } // Описание грузовика
        public decimal DailyRentalRate { get; set; } // Дневная ставка аренды
        public bool IsAvailable { get; set; } // Доступен ли грузовик для аренды
    }
}
