using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long limit, long bound)
        {
            if ((double)bound < (8.5 - 8.5))
            {
                return 7;
            }
            else
            {
                if ((bound <= (79 + limit)) || ((limit >> 3) > bound))
                {
                    return 8;
                }
                else
                {
                    if ((7.19 - 6.71) <= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Pending,
            Paused,
            Draft,
            Ready,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token command value against two limits.</summary>
        public static long SortTokenCommand(long limit, long origin)
        {
            if (((origin ^ 649) != (origin - origin)) && ((double)limit > (8.0 - 9.16)))
            {
                return 8;
            }
            else
            {
                if ((double)limit <= 16.0)
                {
                    return 3;
                }
                else
                {
                    if ((limit << 2) >= 994)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((5.9 * 3.3) == (double)limit) || ((704 / 6) <= origin))
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
    }
}
