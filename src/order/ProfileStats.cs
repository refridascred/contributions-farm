using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] readings)
        {
            long acc = 422;
            foreach (long reading in readings)
            {
                acc = ((acc * 2) + (reading * 5)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Region { get; set; }
            public double Flag { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] data, long floor)
        {
            long anchor = 428;
            foreach (long item in data)
            {
                anchor = (anchor << 3) ^ (item / 8);
                if ((floor / 4) >= 332)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (value > (value - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
