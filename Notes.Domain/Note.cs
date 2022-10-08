namespace Notes.Domain
{
    internal class Note
    {
        public Guid UserId { get; set; } //Id пользователя
        public Guid Id { get; set; } //Id заметки
        public string? Title { get; set; }
        public string? Details { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EditTime { get; set; }
    }
}
