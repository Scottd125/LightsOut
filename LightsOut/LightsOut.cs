using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LightsOut
{
    public partial class LightsOut : MaterialForm
    {
        /// <summary>
        /// Represents the Light's Out game grid
        /// </summary>
        private Grid _gameGrid;

        /// <summary>
        /// Represents the amount of moves the player has taken
        /// </summary>
        private int _moveCount = 0;

        /// <summary>
        /// LightsOut constructor
        /// </summary>
        public LightsOut()
        {
            InitializeComponent();

            // Replace the default Windows form theme with a Material Theme
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Set the Material's colour scheme
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            InitializeUI();
            InitializeGrid();
        }

        /// <summary>
        /// Set up the UI
        /// </summary>
        private void InitializeUI()
        {
            lblMoveCount.Text = "Number of Moves: " + _moveCount;
            cmbGridSize.SelectedIndex = 0;
            cmbGridSize.SelectedIndexChanged += new EventHandler(GridResizeEvent);
        }

        /// <summary>
        /// Create's the grid and runs additional setup before initializing the game
        /// </summary>
        /// <param name="lightsPerRow"></param>
        /// <param name="lightsPerColumn"></param>
        private void InitializeGrid(int lightsPerRow = 5, int lightsPerColumn = 5)
        {
            SetWindowSize(lightsPerRow, lightsPerColumn);

            _gameGrid = new Grid(lightsPerRow, lightsPerColumn);

            foreach (Light light in _gameGrid.Lights)
            {
                Controls.Add(light);
                light.Click += new EventHandler(GridLightClickEvent);
            }
        }


        /// <summary>
        /// Event which is ran when the player clicks a light
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridLightClickEvent(Object sender, EventArgs e)
        {
            UpdateMoveCount();
            Button btn = (Button)sender;
            (int, int) xAndYCoords = ((int, int))btn.Tag;
            int x = xAndYCoords.Item1;
            int y = xAndYCoords.Item2;

            _gameGrid.FlipGridLights(x, y);

            if (_gameGrid.IsWinCondition())
            {
                DisplayWinDialog();
            }
        }

        /// <summary>
        /// Event which is ran when a new grid size has been selected by the player.
        /// Removes the current grid and generates a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridResizeEvent(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            ResizeGrid(comboBox.SelectedIndex);
        }

        /// <summary>
        /// Removes the lights off the form's controls
        /// </summary>
        private void RemoveGrid()
        {
            foreach (Light light in _gameGrid.Lights)
            {
                Controls.Remove(light);
            }
        }

        /// <summary>
        /// Resets the game's grid and state
        /// </summary>
        private void ResetGame()
        {
            ResizeGrid(cmbGridSize.SelectedIndex);
        }

        /// <summary>
        /// Generates a new grid based on the selected size
        /// </summary>
        /// <param name="index"></param>
        private void ResizeGrid(int index)
        {
            _moveCount = 0;
            lblMoveCount.Text = "Number of Moves: " + _moveCount;

            RemoveGrid();

            switch (index)
            {
                case 0:
                    InitializeGrid(5, 5);
                    break;
                case 1:
                    InitializeGrid(6, 6);
                    break;
                case 2:
                    InitializeGrid(7, 7);
                    break;
                case 3:
                    InitializeGrid(8, 8);
                    break;
                case 4:
                    InitializeGrid(9, 9);
                    break;
                case 5:
                    InitializeGrid(10, 10);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Display a win dialog which prompts the player if they want to play again
        /// </summary>
        private void DisplayWinDialog()
        {
            DialogResult result =
                MessageBox.Show("Congratulations, You Win! Would you like to play again?", "You Win! | Lights Out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                ResetGame();
            }
            else
            {
                Close();
            }
        }

        /// <summary>
        /// Scales the window size in relation to the grid size
        /// </summary>
        /// <param name="lightsPerRow"></param>
        /// <param name="lightsPerColumn"></param>
        private void SetWindowSize(int lightsPerRow, int lightsPerColumn)
        {
            switch (lightsPerRow + lightsPerColumn)
            {
                case 10:
                    Size = new Size(750, 550);
                    break;
                case 12:
                    Size = new Size(850, 620);
                    break;
                case 14:
                    Size = new Size(950, 690);
                    break;
                case 16:
                    Size = new Size(1050, 760);
                    break;
                case 18:
                    Size = new Size(1150, 830);
                    break;
                case 20:
                    Size = new Size(1250, 900);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Updates the move count
        /// </summary>
        private void UpdateMoveCount()
        {
            _moveCount++;
            lblMoveCount.Text = "Number of Moves: " + _moveCount;
        }

        /// <summary>
        /// Click event which resets the game
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
