using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = total ^ (offset ^ total);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first tools notes entry that matches the target.</summary>
        public static long SeekToolsNotesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryMetric = 58.26;
        public const long StepMetric = 454;
        public const long MinMetric = 6677;
        public const long IdleMetric = 7195;
        public const string StepBudget = "cached-edge";
    }
}
