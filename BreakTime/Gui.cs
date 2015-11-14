using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakTime
{
    public partial class Gui : Form
    {
        public Gui()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PlugSettings.Instance.Load();
            switch(PlugSettings.Instance.usedMode)
            {
                case mode.dungeon:
                    SelectMode.SelectedIndex = 3;
                    break;
                case mode.bgMode:
                    SelectMode.SelectedIndex = 4;
                    break;
                case mode.petBattleMode:
                    SelectMode.SelectedIndex = 2;
                    break;
                case mode.questMode:
                    SelectMode.SelectedIndex = 1;
                    break;
                case mode.defaultMode:
                    SelectMode.SelectedIndex = 0;
                    break;
                
            }
            NumericMinBotTime.Value = (int)PlugSettings.Instance.minBetweenTime;
            NumericMaxBotTime.Value = (int)PlugSettings.Instance.maxBetweenTime;
            NumericMinBreakTime.Value = (int)PlugSettings.Instance.minBreakTime;
            NumericMaxBreakTime.Value = (int)PlugSettings.Instance.maxBreakTime;
            
        }
        private void SelectMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlugSettings.Instance.Load();
            switch (SelectMode.SelectedIndex)
            {
                case 3:
                    PlugSettings.Instance.usedMode = mode.dungeon;
                    break;
                case 4:
                    PlugSettings.Instance.usedMode = mode.bgMode;
                    break;
                case 2:
                    PlugSettings.Instance.usedMode = mode.petBattleMode;
                    break;
                case 1:
                    PlugSettings.Instance.usedMode = mode.questMode;
                    break;
                case 0:
                    PlugSettings.Instance.usedMode = mode.defaultMode;
                    break;
                default:
                    PlugSettings.Instance.usedMode = mode.defaultMode;
                    break;
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            PlugSettings.Instance.Save();
            Close();
        }
        
        private void NumericMinBotTime_ValueChanged(object sender, EventArgs e)
        {
            PlugSettings.Instance.minBetweenTime = (int)NumericMinBotTime.Value;
        }

        private void NumericMaxBotTime_ValueChanged(object sender, EventArgs e)
        {
            PlugSettings.Instance.maxBetweenTime = (int)NumericMaxBotTime.Value;
        }

        private void NumericMinBreakTime_ValueChanged(object sender, EventArgs e)
        {
            PlugSettings.Instance.minBreakTime = (int)NumericMinBreakTime.Value;
        }

        private void NumericMaxBreakTime_ValueChanged(object sender, EventArgs e)
        {
            PlugSettings.Instance.maxBreakTime = (int)NumericMaxBreakTime.Value;
        }

        private void BreakTime_Click(object sender, EventArgs e)
        {

        }


        //private void SelectMode_MouseHover(object sender, EventArgs e)
        //{
        //    toolTip1.AutoPopDelay = 5000;
        //    toolTip1.InitialDelay = 1000;
        //    toolTip1.ReshowDelay = 500;
        //    toolTip1.ShowAlways = true;
        //    toolTip1.SetToolTip(SelectMode, "Defaultmode: Pauses everywhere\nQuestingmode: Pauses at next Quest turn in\nPetBattlemode; Pauses if you are not in a PetBattle\nBGmode: Pauses if you are not in a Battleground");
        //}
    }
}
