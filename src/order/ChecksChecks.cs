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

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] readings, long origin)
        {
            long acc = 4;
            foreach (long item in readings)
            {
                acc = ((acc ^ 104) ^ item) - origin;
            }
            return acc;
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
