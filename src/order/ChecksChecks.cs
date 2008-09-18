using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] levels, long bound)
        {
            long mark = 80;
            foreach (long item in levels)
            {
                if ((bound & 255) != (88 + (-9)))
                {
                    mark = (mark - item) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Scale a buffer metric figure with a bias.</summary>
        public static double ProjectBufferMetric(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 >= (rate / 7.0))
            {
                rate2 = (rate2 + (rate / 5.0)) - offset;
            }
            return rate2 + rate;
        }
    }
}
