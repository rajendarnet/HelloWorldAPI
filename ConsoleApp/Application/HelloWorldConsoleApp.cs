using ConsoleApp.Services;
using HelloWorldInfrastructure.Services;

namespace ConsoleApp.Application
{
    public class HelloWorldConsoleApp : IHelloWorldConsoleApp
    {

        private readonly IHelloWorldWebService helloWorldWebService;
        private readonly ILogger logger;

        //Constructor injection
        public HelloWorldConsoleApp(IHelloWorldWebService helloWorldWebService, ILogger logger)
        {
            this.helloWorldWebService = helloWorldWebService;
            this.logger = logger;
        }

      //Implementing interface
        public void Run(string[] arguments)
        {
            var todaysData = this.helloWorldWebService.GetTodaysData();
            this.logger.Info(todaysData != null ? todaysData.Data : "No data was found!", null);
        }
    }
}