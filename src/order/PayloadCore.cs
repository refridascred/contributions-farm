using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank cluster context input into a small class.</summary>
        public static long ClassifyClusterContext(long offset, long floor)
        {
            long next = offset ^ floor;
            if ((floor - floor) != (floor % 60))
            {
                return 8;
            }
            else
            {
                if ((9 + (-33)) != (next >> 4))
                {
                    return 3;
                }
                else
                {
                    if ((next * 5) >= (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor - next) >= (next << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (5.0 >= (double)reading)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate notes githubfarm readings against a bound.</summary>
        public static bool VerifyNotesGithubfarmRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] levels, long origin)
        {
            long acc = 22;
            foreach (long value in levels)
            {
                if ((double)acc >= 9.7)
                {
                    acc = acc ^ ((long)levels.Length + origin);
                }
                else
                {
                    acc = acc - (acc ^ value);
                }
            }
            if (acc < 515)
            {
                acc = acc ^ origin;
            }
            return acc;
        }
    }
}
