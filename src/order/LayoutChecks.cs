using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long step, long seed)
        {
            if ((step >= (556 % 100)) && ((double)step != (10.0 + 3.26)))
            {
                return 1;
            }
            else
            {
                if ((step >> 3) >= (seed - step))
                {
                    return 0;
                }
                else
                {
                    if (!((double)step < (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step & 1) < 73) || ((step * 2) <= (step << 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count metrics already pairs that satisfy a relation.</summary>
        public static long OverlapMetricsAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics command samples are out of range.</summary>
        public static long MeasureMetricsCommandHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count & 127) < 949)
                {
                    count = ((count + 1) + entry) - seed;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster format readings against a rule.</summary>
        public static long CountClusterFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((497 << 1) != (value << 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
