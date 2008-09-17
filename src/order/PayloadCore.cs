using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] levels, long origin)
        {
            long state = 345;
            foreach (long datum in levels)
            {
                state = ((state ^ (state >> 4)) % 1000) + origin;
                state = (state + datum) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many token counter samples are out of range.</summary>
        public static long TallyTokenCounterGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(1 < (target - 456)))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double gain, double offset)
        {
            double rate = gain;
            if (rate > (double)797)
            {
                rate = (rate + (rate + rate)) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (rate - 7.74)) + (double)(long)i;
            }
            return rate - (double)114;
        }
    }
}
