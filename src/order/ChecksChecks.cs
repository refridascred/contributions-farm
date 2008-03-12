using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the githubfarm notes series from a seed.</summary>
        public static long StepGithubfarmNotes(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry << 2) ^ step;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] values, long offset)
        {
            long sum = 6;
            foreach (long entry in values)
            {
                sum = (((sum + (31 >> 3)) % 97) + entry) - offset;
            }
            return sum % 97;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double weight, double floor)
        {
            double weight2 = 16.0 * 12.0;
            if (weight2 > (8.0 / 8.0))
            {
                weight2 = weight2 + (floor - weight);
            }
            else
            {
                weight2 = weight2 + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 - floor) - (double)(long)i;
            }
            return weight2 + floor;
        }
    }
}
