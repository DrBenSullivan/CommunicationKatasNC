using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace CommunicationKatas
{
	public class CheeseAdventureV2
    {
        public string CheesePartyDeterminerV2(string grid, int catSpeed, int mouseSpeed)
        {
            ValidateGrid(grid);

            int catIndex = grid.IndexOf("K");
            int mouseIndex = grid.IndexOf("M");
            int cheeseIndex = grid.IndexOf("C");

            bool isCatToLeftOfMouse = catIndex < mouseIndex;
            bool couldCatCatchMouse = isCatToLeftOfMouse && catSpeed > 0 || !isCatToLeftOfMouse && catSpeed < 0;

            bool isMouseToLeftOfCheese = mouseIndex < cheeseIndex;
            bool couldMouseCatchCheese = isMouseToLeftOfCheese && mouseSpeed > 0 || isMouseToLeftOfCheese && mouseSpeed < 0;

            if (!couldCatCatchMouse && !couldMouseCatchCheese) return "Everyone goes hungry!";

            if (couldMouseCatchCheese && !couldCatCatchMouse) return "Cheese";

            while (true)
            {
                catIndex += catSpeed;
                mouseIndex += mouseSpeed;

                if (catIndex >= cheeseIndex && mouseIndex >= cheeseIndex)
                {
                    return "Cheese party!";
                }

                else if (catIndex >= mouseIndex) { return "No cheese"; }

                else if (mouseIndex >= cheeseIndex) { return "Cheese"; }
            }
        }

        private void ValidateGrid(string grid)
        {
            char[] gridChars = grid.ToCharArray();

            int catCount = 0;
            int mouseCount = 0;
            int cheeseCount = 0;
            
            foreach (char c in gridChars)
            {
                if (c == 'K')
                {
                    catCount++;
                    continue;
                }

                if (c == 'M')
                {
                    mouseCount++;
                    continue;
                }

                if (c == 'C')
                {
                    cheeseCount++;
                    continue;
                }

                if (c != '-') throw new ArgumentException("The grid is invalid.");
            }

            if (catCount != 1 || mouseCount != 1 || cheeseCount != 1) throw new ArgumentException("The grid is invalid.");
        }
    }
}
