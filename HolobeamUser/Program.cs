using System;


namespace HolobeamUser
{
    class Program
    {
        public static void Main(string[] args)
        {
            Userdata obj = new Userdata();
            // obj.PostUserAsync("ashik", "asdads@gmail.com", "https://sampleblob123.blob.core.windows.net/samplecontainer/Bale.jpg");

            obj.PostUser("arunraj", "arun@gmail.com", "https://sampleblob123.blob.core.windows.net/samplecontainer/Bale.jpg");
            Console.WriteLine("Enter Username: ");
            string Username = Console.ReadLine();
            obj.GetUser(Username);
            Console.WriteLine("Success");
            Console.Read();
        }
    }
}
