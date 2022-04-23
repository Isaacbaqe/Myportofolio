namespace Core.entities
{
    public class Owner :EntityBase
    {
        public string Fullname { get; set; }
        public string Profil { get; set; }
        public string Avatar { get; set; }
        public Addrress addrress { get; set; }
    }
}
