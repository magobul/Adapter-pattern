using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_pattern
{
    public class ComputerGameAdapter : PCGame
    {
        private readonly ComputerGame _computerGame;

        public ComputerGameAdapter(ComputerGame computerGame)
        {
            _computerGame = computerGame;
        }

        public string getTitle()
        {
            return _computerGame.getName();
        }

        public int getPegiAllowedAge()
        {
            
            return (int)_computerGame.getPegiAgeRating();
        }

        public bool isTripleAGame()
        {
           
            return _computerGame.getBudgetInMillionsOfDollars() > 50;
        }

        public Requirements getRequirements()
        {
           
            return new Requirements
            (
                _computerGame.getMinimumGpuMemoryInMegabytes() / 1024,
                _computerGame.getDiskSpaceNeededInGB(),
                _computerGame.getRamNeededInGb(),
                _computerGame.getCoreSpeedInGhz(),
                _computerGame.getCoresNeeded()
            );
        }
    }
}
