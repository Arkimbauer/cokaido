using System;
using System.Collections.Generic;
using Xunit.Sdk;

namespace GameOfLifeV2
{
    public class Ecosystem
    {
        private List<CellPosition> _currentGeneration = new List<CellPosition>();

        public List<CellPosition> NewGeneration()
        {
            if (_currentGeneration.Count == 0 || _currentGeneration.Count == 1 || _currentGeneration.Count == 2)
            {
                throw new Exception();
            }

            return null;
        }

        public void AddCell(int positionX, int positionY)
        {
            _currentGeneration.Add(new CellPosition(positionX, positionY));
        }
    }
}