namespace WebApplicationRazorPages.Modeles
{
    public class Client
    {
        public string ClientID { get; set; } = string.Empty;
		public string NomCompagnie { get; set; } = string.Empty;
        public string? NomContact { get; set; }
        public string? TitreContact { get; set; }
		public string? Adresse { get; set; }
		public string? Province { get; set; }
		public string? CodePostal { get; set; }
		public string? Pays { get; set; }
		public string? Telephone { get; set; }
        public string? Fax { get; set; }
    }
}
