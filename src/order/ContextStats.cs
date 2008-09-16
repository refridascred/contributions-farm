using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long offset, long limit)
        {
            if (((offset + offset) >= (limit ^ 7)) || ((limit ^ 79) > (offset ^ offset)))
            {
                return 5;
            }
            else
            {
                if ((6.1 - 5.8) > (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long target)
        {
            long slot = step + target;
            if ((slot - target) >= (step - 9))
            {
                return 7;
            }
            else
            {
                if (((step % 16) == (step << 1)) || ((slot >> 4) < ((-820) - slot)))
                {
                    return 8;
                }
                else
                {
                    if ((step - step) <= (47 ^ target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell << 3) >= origin)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public bool Level { get; set; }
        }
    }
}
