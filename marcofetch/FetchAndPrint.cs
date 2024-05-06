namespace marcofetch
{
    internal class FetchAndPrint
    {
        public static void fetch()
        {
            Console.SetCursorPosition(Console.WindowWidth/2, 3);
            Console.WriteLine($"{Environment.UserName}@{Environment.MachineName}");
            Console.SetCursorPosition(Console.WindowWidth / 2, 4);
            Console.WriteLine($"OS: {Environment.OSVersion}");
            Console.SetCursorPosition(Console.WindowWidth / 2, 5);
            Console.WriteLine("Uptime: " + fetchUptime());
        }
        private static string fetchUptime() 
        {
            int uptimeMSec = Environment.TickCount;
            int uptimeSec = uptimeMSec / 1000;
            int uptimeMin = uptimeSec / 60;
            int uptimeHour = uptimeSec / 3600;
            int uptimeDay = uptimeHour / 24;
            uptimeHour = uptimeHour % 24;
            uptimeMin = uptimeMin % 60;
            return $"{uptimeDay} days, {uptimeHour} hours, {uptimeMin} minutes";
        }
    }
}
