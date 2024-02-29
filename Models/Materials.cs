namespace TekhnikaSite.Models
{
    public class Materials
    {
        public int Id { get; set; } // Уникальный идентификатор материала
        public string Name { get; set; } // Название материала
        public string Description { get; set; } // Описание материала
        public decimal PricePerTon { get; set; } // Цена за тонну
        public decimal PricePerCube { get; set; } // Объем в кубических метрах
        public string Variety { get; set; } // Разновидность материала (например, класс, сорт и т. д.)
        public bool IsAvailable { get; set; } // Доступен ли материал для продажи
    }
}
