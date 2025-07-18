namespace PetFinder.Entities
{
    public class PetAppUser
    {
        public required string ID { get; set; } = Guid.NewGuid().ToString(); 

        public required string DisplayName { get; set; }

        public required string ContactEmail { get; set; }

        public bool IsPet { get; set; }

    }
}
