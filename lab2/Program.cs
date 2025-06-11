namespace lab2
{
    class Program
    {
        static void Main()
        {
            var admin = new Admin { UserName = "AdminUser", Email = "admin@example.com" };
            admin.SetPassword("adminpass");

            var moderator = new Moderator { UserName = "ModUser", Email = "mod@example.com" };
            moderator.SetPassword("modpass");

            var regularUser = new RegularUser { UserName = "RegUser", Email = "user@example.com" };
            regularUser.SetPassword("userpass");

            List<User> users = new List<User> { admin, moderator, regularUser };

            Console.WriteLine("=== Інформація про користувачів ===");
            foreach (var user in users)
            {
                user.DisplayInfo();
            }

            Console.WriteLine("\n=== Тестування методів ===");
            foreach (var user in users)
            {
                if (user is Admin a)
                {
                    a.BlockUser(regularUser);
                }
                else if (user is Moderator m)
                {
                    m.ModerateContent();
                }
                else if (user is RegularUser r)
                {
                    r.PostComment();
                }
            }

            Console.WriteLine("\n=== Перевірка аутентифікації ===");
            Console.WriteLine($"{admin.UserName}: {(admin.Authenticate("adminpass") ? "Успішна аутентифікація" : "Невірний пароль")}");
            Console.WriteLine($"{moderator.UserName}: {(moderator.Authenticate("wrongpass") ? "Успішна аутентифікація" : "Невірний пароль")}");
            Console.WriteLine($"{regularUser.UserName}: {(regularUser.Authenticate("userpass") ? "Успішна аутентифікація" : "Невірний пароль")}");
        }
    }
}
