namespace API.Tests.DTO.Responses.Search
{
    public class SearchTeachersResponse
    {
        public partial class Temperatures
        {
            public List<Teacher>? Teachers { get; set; }
            public Pagination? Pagination { get; set; }
        }

        public partial class Pagination
        {
            public long Amount { get; set; }
            public long TotalAmount { get; set; }
            public object? TotalPages { get; set; }
            public object? PageSize { get; set; }
            public long Page { get; set; }
            public long PrevPageElems { get; set; }
            public long NextPageElems { get; set; }
        }

        public partial class Teacher
        {
            public Guid Id { get; set; }
            public string? FirstName { get; set; }
            public string? MiddleName { get; set; }
            public string? LastName { get; set; }
            public object? Description { get; set; }
            public Uri? Avatar { get; set; }
            public double Rating { get; set; }
        }
    }
}
