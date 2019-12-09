using MarsRoverTrioPrograming.Tests;
using Xunit.Abstractions;

namespace MarsRoverTrioPrograming
{
    public class Position : IPosition
    {
        private readonly Direction _direction;
        private readonly Axis _axis;
        private readonly MarsMap _marsMap;

        public Position(Compass direction, int positionY, int positionX)
        {
            _axis = new Axis(positionY, positionX);
            _direction = new Direction(direction);   
            _marsMap = new MarsMap();
        }

        public override string ToString()
        {
            return $"{_axis}:{_direction}";
        }

        public void Move()
        {
            if (Equals(_direction, new Direction(Compass.N)))
            {
                _marsMap.NavigateTo(Compass.N, _axis);
            }

            if (Equals(_direction, new Direction(Compass.NE)))
            {
                _marsMap.NavigateTo(Compass.NE, _axis);
            }

            if (Equals(_direction, new Direction(Compass.E)))
            {
                _marsMap.NavigateTo(Compass.E, _axis);
            }

            if (Equals(_direction, new Direction(Compass.SE)))
            {
                _marsMap.NavigateTo(Compass.SE, _axis);
            }
                
            if (Equals(_direction, new Direction(Compass.S)))
            {
                _marsMap.NavigateTo(Compass.S, _axis);
            }

            if (Equals(_direction, new Direction(Compass.SW)))
            {
                _marsMap.NavigateTo(Compass.SW, _axis);
            }

            if (Equals(_direction, new Direction(Compass.W)))
            {
                _marsMap.NavigateTo(Compass.W, _axis);
            }

            if (Equals(_direction, new Direction(Compass.NW)))
            {
                _marsMap.NavigateTo(Compass.NW, _axis);
            }   
        }

        public void TurnRight() 
        {
            _direction.TurnRight();
        }

        public void TurnLeft()
        {
            _direction.TurnLeft();
        }
    }
}       