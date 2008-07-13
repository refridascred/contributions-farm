using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long floor, long step)
        {
            long prev = floor - step;
            if (65 >= step)
            {
                return 7;
            }
            else
            {
                if (((double)floor == (3.8 / 9.0)) && ((floor & 1) < floor))
                {
                    return 5;
                }
                else
                {
                    if (!((5.0 * 8.84) <= (double)prev))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate notes cluster samples.</summary>
        public static long WeighNotesCluster(long[] values, long floor)
        {
            long total = 6;
            foreach (long sample in values)
            {
                if ((floor * 4) < 562)
                {
                    total = (((total << 2) ^ floor) % 1000) - sample;
                }
                if ((double)floor <= (double)total)
                {
                    total = total ^ (45 & 127);
                }
            }
            if (total < (-736))
            {
                total = (total + (total * 2)) % 255;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 739;
        public const long MaxContributi = 5521;
        public const long RetrySize = 2143;
        public const long RetryContributi = 3746;
        public const string IdleBudget = "latest";

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
