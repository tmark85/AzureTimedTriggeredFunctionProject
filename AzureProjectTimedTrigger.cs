using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

public static class AzureProjectTimedTrigger
{
    [FunctionName("TimerTriggerFunction1")]
    public static void Run1([TimerTrigger("0 */5 * * * *")] TimerInfo myTimer, ILogger log)
    {
        log.LogInformation($"Timer trigger function 1 executed at: {DateTime.Now}");
        // Your function logic here
    }

    [FunctionName("TimerTriggerFunction2")]
    public static void Run2([TimerTrigger("0 0 * * * *")] TimerInfo myTimer, ILogger log)
    {
        log.LogInformation($"Timer trigger function 2 executed at: {DateTime.Now}");
        // Your function logic here
    }

    [FunctionName("TimerTriggerFunction3")]
    public static void Run3([TimerTrigger("0 0 12 * * *")] TimerInfo myTimer, ILogger log)
    {
        log.LogInformation($"Timer trigger function 3 executed at: {DateTime.Now}");
        // Your function logic here
    }
}
