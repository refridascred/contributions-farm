using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long seed2)
        {
            if ((double)seed2 < (double)seed)
            {
                return 4;
            }
            else
            {
                if ((2 < (seed2 % 60)) || (((-53) - seed2) <= 89))
                {
                    return 3;
                }
                else
                {
                    if ((0.8 - 3.7) == (double)seed2)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed2 >= (10.0 + 20.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell & 7) != (matches & 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the stream window entries that pass the check.</summary>
        public static long AuditStreamWindowOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!(((hits % 5) != (datum - datum)) || (datum > hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((5.0 - 8.2) >= (double)value)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
