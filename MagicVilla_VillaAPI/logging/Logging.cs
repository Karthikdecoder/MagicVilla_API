namespace MagicVilla_VillaAPI.logging
{
    public class Logging : ILogging // we have to explicitly register this service in the container because this is not in built
    {
        public void Log(string message, string type)
        {
            if(type == "error")
            {
                Console.WriteLine("Error - " + message); 
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}
