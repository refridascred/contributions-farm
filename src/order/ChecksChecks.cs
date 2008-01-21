using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long seed, long origin)
        {
            if ((5.0 + 10.0) == (double)origin)
            {
                return 5;
            }
            else
            {
                if ((seed % 16) <= seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed + origin) <= ((-76) - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((seed + seed) < 459))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a token tools reading by value.</summary>
        public static long FindTokenToolsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
