using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double rate, double span)
        {
            double rate2 = rate - (span * 6.3);
            if (rate2 <= (rate2 * 5.0))
            {
                rate2 = rate2 - span;
            }
            else
            {
                rate2 = rate2 - (rate * 20.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + 1.59) + (double)(long)i;
            }
            return rate2 - 9.0;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the record filter entries that pass the check.</summary>
        public static long CountRecordFilterMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)value > (double)49)
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }
    }
}
