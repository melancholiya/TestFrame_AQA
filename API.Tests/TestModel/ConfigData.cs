using API.Tests.TestModel;

namespace Test_Fram.TestModel
{
    public class ConfigData
    {
        public string BaseUrl { get; set; } = string.Empty;
        public string LoginUrl { get; set; } = string.Empty;
        public string GeneralUrl { get; set; } = string.Empty;
        public string TeachersUrl { get; set; } = string.Empty;
        public UserManagement UserManagement { get; set; } = default;

        public TeacherManagement TeacherManagement { get; set; } = default;
    }
}
