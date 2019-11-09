using System;
using System.Collections.Generic;
using System.Linq;
using Xunit.Sdk;

namespace GameOfLifeV2
{
    public class Ecosystem
    {
        private List<CellPosition> _currentGeneration = new List<CellPosition>();

        public void NewGeneration()
        {
            if (_currentGeneration.Count == 0 || _currentGeneration.Count == 1 || _currentGeneration.Count == 2)
            {
                throw new Exception();
            }

            var nextGeneration = new List<CellPosition>();
            nextGeneration.Add(new CellPosition(1,0));

            _currentGeneration = nextGeneration;
        }

        public void AddCell(int positionX, int positionY)
        {
            _currentGeneration.Add(new CellPosition(positionX, positionY));
        }

        protected bool Equals(Ecosystem other)
        {
            return _currentGeneration.SequenceEqual(other._currentGeneration);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Ecosystem)obj);
        }

        public override int GetHashCode()
        {
            return (_currentGeneration != null ? _currentGeneration.GetHashCode() : 0);
        }
    }
}