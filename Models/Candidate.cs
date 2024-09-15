namespace btk.Models
{
    public class Candidate 
    {
        public string Email { get; set; } = string.Empty;
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string FullName => $"{Firstname}  {Lastname.ToUpper()}";
        public int Age { get; set; }
        public string SelectedCourse { get; set; } = string.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate(){
            ApplyAt = DateTime.Now;
        }
    }

}
    