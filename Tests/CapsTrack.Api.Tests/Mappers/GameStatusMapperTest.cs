using CapsTrack.api.Mappers;
using CapsTrack.api.Models;
using Microsoft.AspNetCore.Components;
namespace CapsTrack.Api.Tests;


    public class GameStatusMapperTest
    {
        [Fact]
        public void ToGameStatus_MapsFutureToScheduled()
        {
        var nhlStatus = "FUT";

        var result = nhlStatus.ToGameStatus();

        Assert.Equal(GameStatus.Scheduled, result);

        }

        [Theory]
        [InlineData("FUT", GameStatus.Scheduled)]
        [InlineData("PRE", GameStatus.Scheduled)]
        [InlineData("LIVE", GameStatus.Live)]
        [InlineData("CRIT", GameStatus.Live)]
        [InlineData("OFF", GameStatus.Final)]
        [InlineData("FINAL", GameStatus.Final)]
        public void ToGameStatus_MapsKnownStatuses(
            string nhlStatus, 
            GameStatus expected)
        {
        var result = nhlStatus.ToGameStatus();
        Assert.Equal(expected, result);
        }
    [Fact]
    public void ToGameStatus_ReturnsUknownForUnenexpectedStatus()
    {
        var result = "SomethingElse".ToGameStatus();
        Assert.Equal(GameStatus.Unknown, result);
    }
}


