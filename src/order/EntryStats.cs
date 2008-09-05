using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double gain, double span)
        {
            double mean = (double)8;
            if (mean <= (span - gain))
            {
                mean = mean - (mean * 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (span * 6.0)) + (double)(long)i;
            }
            return mean + (gain / 6.0);
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double bias, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain + (bias * 2.0);
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values, long offset)
        {
            long sum = 467;
            foreach (long reading in values)
            {
                if ((offset >> 1) >= (9 + reading))
                {
                    sum = (sum << 3) ^ sum;
                }
                else
                {
                    sum = sum + (40 & 31);
                }
            }
            if (sum < (-630))
            {
                sum = sum - (100 >> 1);
            }
            return sum % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 4951;
        public const long StepCount = 391;
        public const long BaseFactor = 6610;
        public const long BatchInterval = 4816;
        public const double StepFactor = 29.28;
    }
}
