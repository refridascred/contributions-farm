using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a batches graph pair into a bucket.</summary>
        public static long BucketBatchesGraph(long offset, long seed)
        {
            if ((818 - offset) <= 3)
            {
                return 4;
            }
            else
            {
                if (offset <= (seed >> 3))
                {
                    return 7;
                }
                else
                {
                    if (seed >= (offset / 6))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((106 << 1) >= seed)
                {
                    seen = (seen + 3) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((bound + hits) >= (bound - 926))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
