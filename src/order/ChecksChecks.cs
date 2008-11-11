using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            Closed,
            New,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long origin, long bound)
        {
            long cur = origin + bound;
            if (!((53 + bound) == (bound - origin)))
            {
                return 1;
            }
            else
            {
                if ((cur + bound) > (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if ((cur / 5) >= origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin - bound) >= bound) && ((origin << 2) < (cur + cur)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
