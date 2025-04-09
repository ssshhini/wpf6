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

namespace Wpf_Math_practice6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            int taskNumber;
            if (int.TryParse(InputTextBox.Text, out taskNumber))
            {
                string result = ExecuteTask(taskNumber);
                ResultTextBlock.Text = result;
            }
            else
            {
                ResultTextBlock.Text = "Неправильно набран номер задания.";
            }
        }

        private string ExecuteTask(int taskNumber)
        {
            switch (taskNumber)
            {
                case 1:
                    int A1 = 10;
                    int B1 = 7;
                    bool conditionA1 = (A1 % 2 == 0) ^ (B1 % 2 == 0);
                    bool conditionB1 = (A1 % 3 == 0) && (B1 % 3 == 0);
                    return $"Task 1: Условие A это {conditionA1}, Условие B это {conditionB1}.";

                case 2:
                    int N2 = 28;
                    bool conditionA2 = (N2 % 4 == 0) || (N2 % 7 == 0);
                    bool conditionB2 = (N2 % 5 == 0) && (N2 % 10 != 0);
                    return $"Task 2: Условие A это {conditionA2},  Условие B это {conditionB2}.";

                case 3:
                    int n3 = 5, m3 = 3, k3 = 4, l3 = 2;
                    bool condition3 = (n3 + m3 > k3) && (n3 > k3 ? m3 < l3 : true);
                    return $"Task 3: Условие {condition3}.";

                case 4:
                    int N4 = 12;
                    bool condition4 = (N4 % 3 == 0 && N4 % 9 != 0) || (N4 % 4 == 0 && N4 % 5 == 0 && N4 % 24 == 0);
                    return $"Task 4: Условие {condition4}.";

                case 5:
                    int k5 = 0, l5 = 2, n5 = 3, m5 = 1;
                    bool condition5 = (n5 > 1 || m5 <= l5 + k5) && (n5 > 2 ? m5 > 1 : true);
                    return $"Task 5:  Условие {condition5}.";

                case 6:
                    double deposit6 = 60000;
                    double interest6 = deposit6 < 50000 ? 0.16 : deposit6 < 100000 ? 0.18 : 0;
                    double payout6 = deposit6 * (1 + interest6);
                    return $"Task 6: Выплата {payout6}.";

                case 7:
                    int N7 = 14;
                    bool condition7 = (N7 % 2 == 0) && (N7 % 7 == 0) && (N7 % 11 != 0) && (N7 % 13 != 0);
                    return $"Task 7: Условие {condition7}.";

                case 8:
                    int N8 = 70;
                    bool condition8 = (N8 % 3 != 0) && (N8 % 7 == 0) && (N8 % 10 == 0);
                    return $"Task 8: Condition is {condition8}.";

                case 9:
                    int k9 = -1, l9 = 3, n9 = 2, m9 = 4;
                    bool condition9 = (k9 == 0 ? l9 > m9 : k9 < 0 ? 2 * l9 - 3 * n9 < m9 : false);
                    return $"Task 9: Condition is {condition9}.";

                case 10:
                    int N10 = 56;
                    bool condition10 = (N10 % 2 == 0) && (N10 % 3 != 0) && (N10 % 7 == 0) && (N10 % 5 != 0 ? N10 % 4 != 0 : true) && (N10 % 8 == 0 ? N10 % 11 == 0 : true);
                    return $"Task 10: Condition is {condition10}.";

                case 11:
                    double purchase11 = 7000;
                    double discount11 = purchase11 > 4000 && purchase11 < 6000 ? 0.05 : purchase11 > 6000 && purchase11 < 10000 ? 0.10 : 0;
                    double total11 = purchase11 * (1 - discount11);
                    return $"Task 11: Total cost is {total11}.";

                case 12:
                    int k12 = 1, l12 = 2, n12 = 3, m12 = 4;
                    bool condition12 = (k12 + l12 + m12 + n12 > 0) && (k12 > 0 ? 2 * m12 > l12 : k12 < 0 ? n12 > 3 * l12 : false);
                    return $"Task 12: Condition is {condition12}.";

                case 13:
                    int t13 = 23, dt13 = 10;
                    double s13 = 1.5;
                    int d13 = 6;
                    double cost13 = dt13 * s13 * (t13 >= 22 || t13 < 8 ? 0.8 : 1) * (d13 == 6 || d13 == 7 ? 0.9 : 1);
                    return $"Task 13: Cost is {cost13}.";

                case 14:
                    bool X14 = true, Y14 = false, Z14 = true;
                    bool condition14 = !(!X14 && Y14) || (X14 && !Z14);
                    return $"Task 14: Condition is {condition14}.";

                case 15:
                    int physics15 = 5, math15 = 4, compSci15 = 5;
                    bool condition15 = (physics15 >= 4) && (math15 >= 4) && (compSci15 >= 4);
                    return $"Task 15: Condition is {condition15}.";

                case 16:
                    int A16 = 2, B16 = 3, C16 = 4, D16 = 5;
                    int evenCount16 = (A16 % 2 == 0 ? 1 : 0) + (B16 % 2 == 0 ? 1 : 0) + (C16 % 2 == 0 ? 1 : 0) + (D16 % 2 == 0 ? 1 : 0);
                    bool condition16 = evenCount16 == 2;
                    return $"Task 16: Condition is {condition16}.";

                case 17:
                    int A17 = 3, B17 = 5, C17 = 7, D17 = 10;
                    bool condition17 = (A17 % 3 == 0 || B17 % 3 == 0 || C17 % 3 == 0 || D17 % 3 == 0) && (A17 % 5 == 0 || B17 % 5 == 0 || C17 % 5 == 0 || D17 % 5 == 0);
                    return $"Task 17: Condition is {condition17}.";

                case 18:
                    double purchase18 = 15000;
                    double discount18 = purchase18 > 10000 && purchase18 < 20000 ? 0.05 : purchase18 > 20000 && purchase18 < 50000 ? 0.10 : 0;
                    double total18 = purchase18 * (1 - discount18);
                    return $"Task 18: Total cost is {total18}.";

                case 19:
                    int experience19 = 12;
                    double bonus19 = experience19 >= 5 && experience19 < 10 ? 0.02 : experience19 >= 10 && experience19 < 20 ? 0.10 : 0;
                    return $"Task 19: Bonus is {bonus19 * 100}%.";

                case 20:
                    bool X20 = true, Y20 = false, Z20 = true;
                    bool condition20 = X20 && !(!Y20 || Z20) || Y20;
                    return $"Task 20: Condition is {condition20}.";

                case 21:
                    int experience21 = 4;
                    int coefficient21 = experience21 < 2 ? 11 : experience21 < 5 ? 12 : 13;
                    return $"Task 21: Coefficient is {coefficient21}.";

                case 22:
                    int N22 = 6;
                    bool condition22 = (N22 % 2 == 0) && (N22 % 3 == 0) && (N22 % 5 != 0);
                    return $"Task 22: Condition is {condition22}.";

                case 23:
                    int N23 = 21;
                    bool condition23 = (N23 % 7 == 0) && (N23 % 2 != 0);
                    return $"Task 23: Condition is {condition23}.";

                case 24:
                    bool A24 = true, B24 = false, C24 = true;
                    bool condition24 = A24 && !B24 || !(A24 || !C24);
                    return $"Task 24: Condition is {condition24}.";

                case 25:
                    int A25 = 7, B25 = 3, C25 = 5, D25 = 2;
                    bool condition25 = (A25 % 7 == 0 || B25 % 7 == 0 || C25 % 7 == 0 || D25 % 7 == 0) && (A25 % 2 != 0 || B25 % 2 != 0 || C25 % 2 != 0 || D25 % 2 != 0);
                    return $"Task 25: Condition is {condition25}.";

                case 26:
                    int N26 = 12;
                    bool condition26 = (N26 % 5 != 0) && (N26 % 2 == 0) && (N26 % 3 == 0);
                    return $"Task 26: Condition is {condition26}.";

                case 27:
                    double a27 = -1, b27 = 2, c27 = 3;
                    double discriminant27 = b27 * b27 - 4 * a27 * c27;
                    bool condition27 = discriminant27 >= 0;
                    return $"Task 27: Condition is {condition27}.";

                default:
                    return "Task number not recognized.";
            }
        }
    }
}
