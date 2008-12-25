using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((item / 2) > item))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Locked,
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items, long bound)
        {
            long result = 5;
            foreach (long reading in items)
            {
                result = result - (reading + reading);
                result = ((result << 3) ^ bound) % 1000;
            }
            if (result < (-181))
            {
                result = (result + (result >> 3)) % 101;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowSpan = 6330;
        public const string CacheBatches = "local-1";
        public const long MinBatches = 1248;
        public const long StepBatches = 4744;
        public const long SoftFactor = 7121;
    }
}
