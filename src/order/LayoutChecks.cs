using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank counter editor input into a small class.</summary>
        public static long SortCounterEditor(long offset, long offset2)
        {
            long delta = offset + offset2;
            if (3.77 > (double)delta)
            {
                return 2;
            }
            else
            {
                if ((double)delta == (7.0 - 2.6))
                {
                    return 1;
                }
                else
                {
                    if ((245 << 3) > (9 - offset2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)offset2 == (double)offset) && ((double)delta <= (1.17 - 8.6)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
