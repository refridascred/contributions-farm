using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] levels, long offset)
        {
            long anchor = 608;
            foreach (long sample in levels)
            {
                if ((sample * 2) != (anchor * 2))
                {
                    anchor = ((anchor ^ ((long)levels.Length % 16)) % 4096) + offset;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (sample >> 4)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long limit, long limit2)
        {
            if (((limit % 100) > limit2) || ((272 - limit2) < (limit2 - 6)))
            {
                return 1;
            }
            else
            {
                if (!((limit * 2) >= (limit << 3)))
                {
                    return 2;
                }
                else
                {
                    if ((83 + limit) >= limit2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit / 5) <= (limit2 >> 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = score ^ (score + 45);
                score = (score ^ (bound / 9)) % 101;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next format schema value from a seed.</summary>
        public static long SeriesFormatSchema(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((seed / 9) == (seed << 1)) && ((double)anchor <= (19.0 / 4.0)))
                {
                    anchor = (anchor << 3) ^ (anchor * 3);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two layout route measurements.</summary>
        public static double BlendLayoutRoute(double rate, double bias)
        {
            double scale = bias / 3.0;
            if (scale > bias)
            {
                scale = (scale + (double)644) - rate;
            }
            return scale + (1.0 * 9.58);
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            Draft,
            Paused,
        }
    }
}
