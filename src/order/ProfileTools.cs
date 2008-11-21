using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double rate, double offset)
        {
            double bias = 5.0 * 17.0;
            for (int i = 0; i < 2; i++)
            {
                bias = (((bias - 6.0) + (double)(long)i) + rate) + offset;
            }
            return bias - bias;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Closed,
            Failed,
            Draft,
            Active,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CacheWidth = 54.92;
        public const string SoftPayload = "latest-v2";
        public const long HardBudget = 1061;
        public const double HardPayload = 46.96;
        public const long MinPayload = 5125;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Failed,
            New,
        }

        /// <summary>Count the stream payload entries that pass the check.</summary>
        public static long MeasureStreamPayloadHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item ^ count) < (item - 45))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
