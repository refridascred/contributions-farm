using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 6182;
        public const double CacheCount = 3.77;
        public const long HardMetrics = 4158;
        public const long SoftMetrics = 6659;
        public const double BurstMetrics = 21.79;

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] readings)
        {
            long anchor = 70;
            foreach (long cell in readings)
            {
                if (!(cell > (anchor / 8)))
                {
                    anchor = anchor + (726 + (long)readings.Length);
                }
                if ((anchor >= (anchor + cell)) || ((cell - anchor) >= cell))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Classify a schema metric pair into a bucket.</summary>
        public static long ClassifySchemaMetric(long limit, long origin)
        {
            if ((limit + limit) < limit)
            {
                return 0;
            }
            else
            {
                if ((limit + origin) < (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if ((599 + limit) < (origin % 100))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin == (18.0 - 6.94))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample > (74 - 15))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((double)matches != (15.0 / 6.0)))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                if ((anchor + target) >= anchor)
                {
                    anchor = (anchor - anchor) % 4096;
                    anchor = anchor - (target << 1);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
