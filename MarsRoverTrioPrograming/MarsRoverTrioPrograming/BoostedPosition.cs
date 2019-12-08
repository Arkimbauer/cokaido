namespace MarsRoverTrioPrograming
{
    public class BoostedPosition : IPosition
    {
        public Direction Direction;
        private readonly Axis _axis;


        public BoostedPosition(Compass direction = Compass.N, int positionY = 0, int positionX = 0)
        {   
            _axis = new Axis(positionY, positionX);
            Direction = new Direction(direction);
        }

        public override string ToString()
        {
            return $"{_axis}:{Direction}";
        }

        public void Move()
        {
            const int upRightLimitPosition = 10;
            const int downLeftLimitPosition = 0;

            if (Equals(Direction, new Direction(Compass.N)) && _axis.PositionY < upRightLimitPosition)
            {
                _axis.MoveNorth();
                _axis.MoveNorth();
            }

            if (Equals(Direction, new Direction(Compass.E)) && _axis.PositionX < upRightLimitPosition)
            {
                _axis.MoveEast();
                _axis.MoveEast();
            }

            if (Equals(Direction, new Direction(Compass.S)) && _axis.PositionY > downLeftLimitPosition)
            {
                _axis.MoveSouth();
                _axis.MoveSouth();
            }

            if (Equals(Direction, new Direction(Compass.W)) && _axis.PositionX > downLeftLimitPosition)
            {
                _axis.MoveWest();
                _axis.MoveWest();
            }
        }

        public void TurnRight()
        {
            Direction.TurnRight();
        }

        public void TurnLeft()
        {
            Direction.TurnLeft();
        }
    }
}