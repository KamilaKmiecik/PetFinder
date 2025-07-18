using PetFinder.Entities;

namespace PetFinder.Data
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.PetUsers.Any())
            {
                return;
            }

            var users = new PetAppUser[]
            {
                new PetAppUser
                {
                    ID = Guid.NewGuid().ToString(),
                    DisplayName = "Azor",
                    ContactEmail = "123@gmail.com",
                    IsPet = true,
                },
                new PetAppUser
                {
                    ID = Guid.NewGuid().ToString(),
                    DisplayName = "Moris",
                    ContactEmail = "123@gmail.com",
                    IsPet = true,
                },
                new PetAppUser
                {
                    ID = Guid.NewGuid().ToString(),
                    DisplayName = "Anna",
                    ContactEmail = "123@gmail.com",
                    IsPet = false,
                },


            };

            context.PetUsers.AddRange(users);
            context.SaveChanges();
        }
    }
}
