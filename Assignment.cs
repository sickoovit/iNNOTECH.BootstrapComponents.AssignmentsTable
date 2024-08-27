namespace AssignmentTable
{
    public class Assignment
    {
        public required string Topic { get; set; }
        public DateTime DateAssigned { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public string? Grade { get; set; }
        public bool IsSubmitted => DateSubmitted.HasValue;
    }
}
