using System.Drawing;
using System.Windows.Forms;

namespace LightsOut
{
    public class Light : Button
    {
        /// <summary>
        /// Represents the light's on colour
        /// </summary>
        public static readonly Color LightOnColour = Color.DarkGreen;

        /// <summary>
        /// Represents the light's off colour
        /// </summary>
        public static readonly Color LightOffColour = Color.LightGreen;

        /// <summary>
        /// Represents the light's height
        /// </summary>
        private const int _lightHeight = 75;

        /// <summary>
        /// Represents the light's width
        /// </summary>
        private const int _lightWidth = 75;

        /// <summary>
        /// Represents the distance between each light
        /// </summary>
        private const int _lightDistance = 20;

        /// <summary>
        /// Light's constructor
        /// </summary>
        public Light()
        {

        }

        /// <summary>
        /// Method to generate a new light
        /// </summary>
        /// <param name="gridOffsetX"></param>
        /// <param name="gridOffsetY"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns>A Light button</returns>
        public Light GenerateNewLight(int gridOffsetX, int gridOffsetY, int row, int column)
        {
            return new Light
            {
                Top = gridOffsetY + (row * _lightHeight + _lightDistance),
                Left = gridOffsetX + (column * _lightWidth + _lightDistance),
                Width = _lightWidth,
                Height = _lightHeight,
                BackColor = LightOffColour,
                Tag = (row, column),
            };
        }
    }
}
