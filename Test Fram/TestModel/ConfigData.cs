namespace Test_Fram.TestModel
{
    public class ConfigData
    {
        public string BaseUrl { get; set; } = string.Empty;
        public string LoginUrl { get; set; } = string.Empty;
        public string GeneralUrl { get; set; } = string.Empty;
        public UserManagement UserManagement { get; set; } = default;
    }
}
