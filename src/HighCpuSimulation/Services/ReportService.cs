namespace HighCpuSimulation.Services;

public static class ReportService
{
    public static Guid GenerateReport()
    {
        var requestId = Guid.NewGuid();

        Task.Run(() =>
        {
            // Simulating high CPU usage with string manipulations
            var result = string.Empty;
            for (var i = 0; i < 5000; i++)
            {
                var dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                result += $"This is a test: {dateTime}";
            }

            // Save the result to a file
            SaveResult(requestId, result);
        });

        return requestId;
    }

    private static void SaveResult(Guid requestId, string result)
    {
        // Write result to a file
    }
}