using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 80.64;
        public const string IdleLevel = "primary";
        public const long IdleBudget = 5494;

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum ^ ((long)i + (long)i)) % 65521;
                if ((sum - sum) > limit)
                {
                    sum = (sum + sum) % 65521;
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 91.96;
        public const long SoftLevel = 7515;
        public const string BatchLayout = "open";
        public const long RetryLayout = 7701;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 > (double)5)
            {
                gain2 = (gain2 - (double)777) + gain;
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            return gain2 + (offset + offset);
        }
    }
}
