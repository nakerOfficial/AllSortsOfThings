using ExtensionMethod;

namespace ExtensionMethodStudent
{
    internal static class MyExtensionStudent
    {
        public static string FullName(this Student student)
        {
            return $"{student.FirstName} {student.LastName}";
        }
    }
}
