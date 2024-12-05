using Lab2.Interfaces;

namespace Lab2
{
    public static class Helper
    {
        public static void SetCreationUser(ICreationTime creationTime)
        {
            creationTime.CreationTime = DateTime.Now;
        }
    }
}
