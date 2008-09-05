using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Active,
            Stale,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long seed, long offset)
        {
            if ((seed & 63) <= (offset >> 2))
            {
                return 6;
            }
            else
            {
                if (!((742 << 2) > offset))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed == (8.8 * 9.6))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((998 >> 5) > (offset - seed))
                        {
                            return 0;
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
