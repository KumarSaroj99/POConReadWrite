namespace POConRWwithHTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\sarojkumar.panda\\Desktop\\.netTraining\\POConRWwithHTML\\htmlExample.html";

            // Write HTML content to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("<!DOCTYPE html>");
                writer.WriteLine("<html>");
                writer.WriteLine("<head>");
                writer.WriteLine("<title>My HTML File</title>");
                writer.WriteLine("</head>");
                writer.WriteLine("<body>");
                writer.WriteLine("<h1>Hello, World!</h1>");
                writer.WriteLine("<p>This is a  HTML file created For POC on file handling.</p>");
                writer.WriteLine("</body>");
                writer.WriteLine("</html>");
            }

            Console.WriteLine("HTML content written to file successfully.");

            // Read the HTML content from the file
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine("HTML content read from file successfully.");
        }
    }
}
