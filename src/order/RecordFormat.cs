using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            New,
            Pending,
            Idle,
            Dropped,
        }

        /// <summary>Scale a cluster channel figure with a bias.</summary>
        public static double BlendClusterChannel(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 < (floor * 7.44))
            {
                gain2 = gain2 + (floor + gain2);
            }
            else
            {
                gain2 = gain2 - (double)5;
            }
            return gain2 - gain;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 504;
        public const long BurstToken = 3370;
        public const long WindowFactor = 4854;
        public const string WindowDepth = "primary-1";

        /// <summary>Fold a list of schema batches readings.</summary>
        public static long FoldSchemaBatches(long[] samples)
        {
            long sum = 2;
            foreach (long item in samples)
            {
                sum = ((sum << 3) ^ (sum ^ sum)) % 97;
                sum = ((sum * 3) + sum) % 97;
                if ((21 + item) >= 28)
                {
                    sum = ((sum << 2) ^ (14 * 3)) % 97;
                }
                else
                {
                    sum = (sum - 387) % 255;
                }
                if (((double)sum != (2.53 + 6.9)) && ((item + item) >= (item << 2)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string HardSize = "local";
        public const long IdleScore = 248;
        public const long StepRatio = 3433;
        public const long HardAccount = 8665;
    }
}
