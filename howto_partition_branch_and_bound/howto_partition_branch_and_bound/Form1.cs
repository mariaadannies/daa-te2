using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;

namespace howto_partition_branch_and_bound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] Values = null;
        private int NodesVisited = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            Values = new int[]
            {
                5627, 6647, 3638, 6868, 5814, 
                1768, 5049, 3927, 9673, 6443, 
                4981, 1037, 9333, 4964, 1666, 
                2533, 1989, 7395, 4896, 1105, 
                7548, 5933, 5542, 7956, 6052, 
                2516, 2023, 4624, 5406, 5270, 
            };
            lstValues.DataSource = Values;

            lblNumValues.Text = lstValues.Items.Count.ToString() + " values";
        }

        private void btnPartition_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            txtItems1.Clear();
            txtItems2.Clear();
            txtTotal1.Clear();
            txtTotal2.Clear();
            txtNodesVisited.Clear();
            txtTime.Clear();
            Application.DoEvents();

            // Get the item values.
            int[] values = (int[])Values.Clone();

            // Partition the values.
            Stopwatch watch = new Stopwatch();
            watch.Start();
            bool[] best_assignment = PartitionValues(values);
            watch.Stop();

            // Display the results.
            string result1 = "", result2 = "";
            int total1 = 0, total2 = 0;
            for (int i = 0; i < best_assignment.Length; i++)
            {
                if (best_assignment[i])
                {
                    result1 += "\r\n" + values[i];
                    total1 += values[i];
                }
                else
                {
                    result2 += "\r\n" + values[i];
                    total2 += values[i];
                }
            }
            if (result1.Length > 0) result1 = result1.Substring(2);
            if (result2.Length > 0) result2 = result2.Substring(2);

            txtItems1.Text = result1;
            txtItems2.Text = result2;
            txtTotal1.Text = total1.ToString();
            txtTotal2.Text = total2.ToString();
            txtNodesVisited.Text = NodesVisited.ToString("N0");
            txtTime.Text = watch.Elapsed.TotalSeconds.ToString("0.00") + " sec";
            Cursor = Cursors.Default;
        }

        // Partition the values. Return an array with entry i = true if
        // value i belongs in the first set of the partition.
        private bool[] PartitionValues(int[] values)
        {
            // Make variables to track the best solution and a test solution.
            bool[] best_assignment = new bool[values.Length];
            bool[] test_assignment = new bool[values.Length];

            // Get the total of all values.
            int total_value = values.Sum();

            // Partition the values starting with index 0.
            int best_err = total_value;
            NodesVisited = 0;
            PartitionValuesFromIndex(values, 0, total_value, total_value,
                test_assignment, 0, ref best_assignment, ref best_err);

            // Return the result.
            return best_assignment;
        }

        // Partition the values keeping those before index start_index fixed.
        // test_assignment is the test assignment so far.
        // test_value is the total value of the first set in the test assignment.
        // Initially best assignment and its error are in best_assignment and best_err.
        // Update those to reflect any improved solution we find.
        private void PartitionValuesFromIndex(int[] values, int start_index, int total_value,
            int unassigned_value, bool[] test_assignment, int test_value,
            ref bool[] best_assignment, ref int best_err)
        {
            // If start_index is beyond the end of the array,
            // then all entries have been assigned.
            if (start_index >= values.Length)
            {
                // We're done. See if this assignment is better than what we have so far.
                int test_err = Math.Abs(2 * test_value - total_value);
                if (test_err < best_err)
                {
                    // This is an improvement. Save it.
                    best_err = test_err;
                    best_assignment = (bool[])test_assignment.Clone();

                    Console.WriteLine(best_err);
                }
            }
            else
            {
                // See if there's any way we can assign
                // the remaining items to improve the solution.
                int test_err = Math.Abs(2 * test_value - total_value);
                if (test_err - unassigned_value < best_err)
                {
                    // There's a chance we can make an improvement.
                    // We will now assign the next item.
                    unassigned_value -= values[start_index];

                    // Try adding values[start_index] to set 1.
                    test_assignment[start_index] = true;
                    NodesVisited++;
                    PartitionValuesFromIndex(values, start_index + 1, total_value, unassigned_value,
                        test_assignment, test_value + values[start_index],
                        ref best_assignment, ref best_err);

                    // Try adding values[start_index] to set 2.
                    test_assignment[start_index] = false;
                    NodesVisited++;
                    PartitionValuesFromIndex(values, start_index + 1, total_value, unassigned_value,
                        test_assignment, test_value,
                        ref best_assignment, ref best_err);
                }
            }
        }
    }
}
