using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Optimization_Paragon
{
    public partial class MainWindow : Window
    {
        private DamageOptimizationNormal op = new DamageOptimizationNormal(100);
        private int Points {get; set;}

        public MainWindow()
        {
            InitializeComponent();
            CbCritDmg.ItemsSource = new int[] { 150, 250 };
            CbCritDmg.SelectedIndex = 0;
            TbCritRules.Text = op.CritRules().ToString();
        }

        private void BtnOptimizeDmg_Click(object sender, RoutedEventArgs e)
        {
            op.Optimize(Points);
            TbIncrDmg.Text = op.DmgPct.ToString();
            TbAttackSpeed.Text = op.AttackSpeedPoints.ToString();
            TbCritChance.Text = op.CritPoints.ToString();
            TbPower.Text = op.PowerPoints.ToString();
        }

        private void SlPoints_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double newStep = Math.Round(e.NewValue);
            SlPoints.Value = newStep;
            Points = (int) SlPoints.Value;
        }

        private void CbCritDmg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            op.IncrCritPct = ((int) CbCritDmg.SelectedValue) - 150;

            if(op.IncrCritPct == 0)
            {
                SlPoints.Maximum = 60 + 6;
            }

            if (op.IncrCritPct == 100)
            {
                SlPoints.Maximum = 54 + 5;
            }
        }
    }
}
