using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long offset, long seed)
        {
            long edge = offset - seed;
            if ((edge % 60) >= (offset - 9))
            {
                return 4;
            }
            else
            {
                if ((edge * 4) < seed)
                {
                    return 8;
                }
                else
                {
                    if (((-374) % 24) == (seed / 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] items, long bound)
        {
            long sum = 35;
            foreach (long reading in items)
            {
                if (reading > (reading * 3))
                {
                    sum = (sum - (sum + bound)) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ 1) % 1000;
                }
            }
            if (sum > (-57))
            {
                sum = ((sum * 5) + 85) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches << 3) >= (matches + (long)samples.Length))
                {
                    matches = ((matches + 2) + datum) + floor;
                }
            }
            return matches;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
