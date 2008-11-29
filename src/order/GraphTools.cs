using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double ratio, double floor)
        {
            double gain = (double)12 + ratio;
            if (gain >= ratio)
            {
                gain = gain - 7.53;
            }
            else
            {
                gain = gain + (gain * 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 3508;
        public const double SoftWidth = 15.9;
        public const long StepCluster = 3747;
        public const double MaxBudget = 48.6;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum - (sum * 4)) % 101;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 8825;
        public const long CacheEditor = 6044;
        public const long MinWidth = 9574;
        public const long HardEditor = 4066;

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] series)
        {
            long carry = 822;
            foreach (long value in series)
            {
                if (((35 + carry) < (carry + value)) || ((carry + (long)series.Length) == (carry << 2)))
                {
                    carry = ((carry * 5) + carry) % 255;
                }
                if ((carry % 24) == (5 % 60))
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
