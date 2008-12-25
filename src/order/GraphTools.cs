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

        /// <summary>Count channel route pairs that satisfy a relation.</summary>
        public static long CompareChannelRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
