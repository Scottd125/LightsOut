using System;
using System.Linq;

namespace LightsOut
{
    public class Grid
    {
        /// <summary>
        /// Represents all the lights within the grid
        /// </summary>
        public Light[,] Lights { get; }

        /// <summary>
        /// Represents the amount of lights per row
        /// </summary>
        public int LightsPerRow { get; private set; }

        /// <summary>
        /// Represents the amount of lights per column
        /// </summary>
        public int LightsPerColumn { get; private set; }

        /// <summary>
        /// Represents the grid's offset on the x axis
        /// </summary>
        private const int _gridOffsetX = 10;

        /// <summary>
        /// Represents the grid's offset on the y axis
        /// </summary>
        private const int _gridOffsetY = 75;

        /// <summary>
        /// Used to generate random numbers
        /// </summary>
        private readonly Random _random = new Random();

        /// <summary>
        /// Grid constructor (Generates a grid filled with lights)
        /// </summary>
        /// <param name="lightsPerRow"></param>
        /// <param name="lightsPerColumn"></param>
        /// <returns>A gird of lights</returns>
        public Grid(int lightsPerRow = 5, int lightsPerColumn = 5)
        {
            LightsPerRow = lightsPerRow;
            LightsPerColumn = lightsPerColumn;

            Lights = new Light[LightsPerRow, LightsPerColumn];
            for (int row = 0; row < LightsPerRow; row++)
            {
                for (int column = 0; column < LightsPerColumn; column++)
                {
                    Lights[row, column] = new Light().GenerateNewLight(_gridOffsetX, _gridOffsetY, row, column);
                }
            }

            InitializeGame();
        }

        /// <summary>
        /// Randomly generates the states of the lights on the grid (On or Off)
        /// </summary>
        public void InitializeGame()
        {
            for (int row = 0; row < LightsPerRow; row++)
            {
                for (int column = 0; column < LightsPerColumn; column++)
                {
                    if (_random.Next(2) == 1)
                    {
                        Lights[row, column].BackColor = Light.LightOnColour;
                    }
                    else
                    {
                        Lights[row, column].BackColor = Light.LightOffColour;
                    }
                }
            }
        }

        /// <summary>
        /// Toggles the clicked light state and it's as well as it's surrounding lights
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void FlipGridLights(int x, int y)
        {
            ToggleGridLightColour(x, y);

            if (x > 0)
            {
                ToggleGridLightColour(x - 1, y);
            }
            if (x < LightsPerRow - 1)
            {
                ToggleGridLightColour(x + 1, y);
            }
            if (y > 0)
            {
                ToggleGridLightColour(x, y - 1);
            }
            if (y < LightsPerColumn - 1)
            {
                ToggleGridLightColour(x, y + 1);
            }
        }

        /// <summary>
        /// Check's all the light's state to see if the player has won (If all light's are off)
        /// </summary>
        /// <returns>Win state</returns>
        public bool IsWinCondition()
        {
            return Lights.OfType<Light>().All(light => light.BackColor == Light.LightOffColour);
        }

        /// <summary>
        /// Inverts the light's colour
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void ToggleGridLightColour(int x, int y)
        {
            if (Lights[x, y].BackColor == Light.LightOffColour)
            {
                Lights[x, y].BackColor = Light.LightOnColour;
            }
            else
            {
                Lights[x, y].BackColor = Light.LightOffColour;
            }
        }
    }
}
