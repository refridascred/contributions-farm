using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((2.15 * 8.0) == (double)hits)
                {
                    hits = ((hits + 2) + reading) + seed;
                }
            }
            return hits;
        }

        /// <summary>Count the window profile entries that pass the check.</summary>
        public static long MeasureWindowProfileOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((double)value > (double)seen))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Grade a notes githubfarm value against two limits.</summary>
        public static long RankNotesGithubfarm(long offset, long bound)
        {
            if ((offset % 12) < offset)
            {
                return 8;
            }
            else
            {
                if (offset <= (bound & 127))
                {
                    return 5;
                }
                else
                {
                    if (offset > (bound / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + bound) >= (offset / 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            New,
            Active,
            Locked,
        }

        /// <summary>Blend two cache filter measurements.</summary>
        public static double BlendCacheFilter(double rate, double bias)
        {
            double rate2 = (double)(-4) + (rate * 6.0);
            return (rate2 + rate2) + bias;
        }
    }
}
