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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long seed, long origin)
        {
            if ((15.0 + 0.82) > (double)origin)
            {
                return 3;
            }
            else
            {
                if (seed <= origin)
                {
                    return 6;
                }
                else
                {
                    if (seed >= (origin - 40))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((10.0 - 3.5) == (double)seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count <= (4.0 - 2.55))
                {
                    count = ((count + 2) + item) + seed;
                }
            }
            return count;
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

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
