using HelloWorldInfrastructure.Models;
namespace HelloWorldInfrastructure.Mappers
{
   

    /// <summary>
    ///     Mapper service for mapping types for the Hello World data service
    /// </summary>
    public interface IHelloWorldMapper
    {
        /// <summary>
        ///     Maps a string to a TodaysData model
        /// </summary>
        /// <param name="input">The input</param>
        /// <returns>A TodaysData model</returns>
        TodaysData StringToTodaysData(string input);
    }
}