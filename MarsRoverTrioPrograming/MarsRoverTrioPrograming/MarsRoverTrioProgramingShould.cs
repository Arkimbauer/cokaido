using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Xunit;

namespace MarsRoverTrioPrograming
{
    public class MarsRoverTrioProgramingShould
    {
        private readonly MarsRover _marsRover;

        public MarsRoverTrioProgramingShould()
        {
            _marsRover = new MarsRover();
        }

        [Fact]
        public void StayInPlaceGivenNoCommand()
        {
            var result = _marsRover.Execute(string.Empty);
            Assert.Equal("0:0:N", result);
        }

        [Theory]
        [InlineData("0:1:N", "M")]
        [InlineData("0:2:N", "MM")]
        [InlineData("0:3:N", "MMM")]
        public void MoveAnyPositionsGivenCommandM(string expectedPosition, string command)
        {
            var position = _marsRover.Execute(command);
            Assert.Equal(expectedPosition, position);
        }

        [Theory]
        [InlineData("0:0:E", "R")]
        [InlineData("0:0:S", "RR")]
        [InlineData("0:0:W", "RRR")]
        [InlineData("0:0:N", "RRRR")]
        public void TurnRightGivenCommandR(string expectedPosition, string command)
        {
            var position = _marsRover.Execute(command);
            Assert.Equal(expectedPosition, position);
        }

        [Theory]
        [InlineData("0:0:W", "L")]
        [InlineData("0:0:S", "LL")]
        [InlineData("0:0:E", "LLL")]
        [InlineData("0:0:N", "LLLL")]
        public void TurnLeftGivenCommandL(string expectedPosition, string command)
        {
            var position = _marsRover.Execute(command);
            Assert.Equal(expectedPosition, position);   
        }

        [Fact]
        public void TurnRightAndMoveOnePosition()
        {
            var position = _marsRover.Execute("RM");
            Assert.Equal("1:0:E", position);
        }   

        [Theory]
        [InlineData("2:1:E", "RM")]
        [InlineData("0:1:W", "LM")]
        [InlineData("1:0:S", "RRM")]
        public void MoveOnePositionForEachCompassDirection(string expectedPosition, string commands)
        {
            Position startPosition = new Position(Compass.N, 1, 1);
            var marsRover = new MarsRover(startPosition);
            var position = marsRover.Execute(commands);
            Assert.Equal(expectedPosition, position);
        }

        [Theory]
        [InlineData("0:2:N", "M")]
        [InlineData("0:4:N", "MM")]
        [InlineData("2:2:N", "RMLM")]
        public void MoveTwoPositionsGivenOneMCommand(string expectedPosition, string commands)
        {
            var marsRover = new MarsRover(new BoostedPosition());
            var position = marsRover.Execute(commands);
            Assert.Equal(expectedPosition, position);
        }
    }
}   
    