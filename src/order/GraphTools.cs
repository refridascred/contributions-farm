using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry % 16) > (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every format checks entry stays within the limit.</summary>
        public static bool CheckFormatChecksBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Done,
            Queued,
            Draft,
            Closed,
            Active,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double gain, double offset)
        {
            double mean = offset - (double)0;
            return mean + gain;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long step, long origin)
        {
            long delta = step + origin;
            if ((delta << 1) >= (origin ^ origin))
            {
                return 0;
            }
            else
            {
                if ((729 & 63) <= (delta / 6))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin <= 6.3)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.0 / 3.0) < (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
