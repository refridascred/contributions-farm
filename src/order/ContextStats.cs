using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many graph layout samples are out of range.</summary>
        public static long TallyGraphLayoutGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((origin ^ seen) > seen) && ((origin * 5) != (item - item)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 9936;
        public const double MinSpan = 6.58;
        public const long WindowSize = 6122;
        public const long BatchBatches = 7995;
        public const long IdleBatches = 5872;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long floor, long offset)
        {
            if ((floor - offset) < (floor - floor))
            {
                return 0;
            }
            else
            {
                if ((double)offset < (5.0 + 4.9))
                {
                    return 4;
                }
                else
                {
                    if ((offset & 31) <= offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)5 < (double)offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
