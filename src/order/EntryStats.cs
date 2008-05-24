using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] samples)
        {
            long mix = 23;
            foreach (long entry in samples)
            {
                if (!((entry << 3) > mix))
                {
                    mix = mix - (mix % 100);
                }
                else
                {
                    mix = (mix - (entry >> 3)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double gain, double floor)
        {
            double ratio = gain;
            if (ratio <= floor)
            {
                ratio = ratio + floor;
            }
            return ratio - 1.8;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long target)
        {
            long slot = step ^ target;
            if ((target > slot) && ((16.0 - 6.35) < (2.43 + 10.0)))
            {
                return 8;
            }
            else
            {
                if ((15 < slot) && ((step + step) >= (target - step)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Done,
            Locked,
            Synced,
            Retry,
        }
    }
}
