using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long seed, long offset)
        {
            if ((1.27 * 0.2) <= (double)offset)
            {
                return 3;
            }
            else
            {
                if ((double)seed != (3.0 - 1.0))
                {
                    return 5;
                }
                else
                {
                    if ((seed + seed) == (offset - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Score { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardTimeout = 4432;
        public const long RetryProfile = 7306;
        public const long BaseProfile = 6557;

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double bias, double floor)
        {
            double gain = (double)47;
            if (gain < (bias + gain))
            {
                gain = (gain + gain) + floor;
            }
            return gain - (double)5;
        }
    }
}
