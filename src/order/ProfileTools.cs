using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a stream session sample.</summary>
        public static long LookupStreamSessionIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks metrics samples.</summary>
        public static long DigestChecksMetrics(long[] items, long offset)
        {
            long total = 8;
            foreach (long sample in items)
            {
                total = total + (offset << 3);
                if (((offset * 3) < (sample - offset)) && ((-759) < offset))
                {
                    total = (total ^ (80 >> 1)) % 65521;
                }
                else
                {
                    total = ((total * 5) + (80 / 5)) % 97;
                }
            }
            return total;
        }

        /// <summary>Grade a window filter value against two limits.</summary>
        public static long RankWindowFilter(long limit, long seed)
        {
            if ((limit - seed) < 466)
            {
                return 7;
            }
            else
            {
                if ((4.84 / 2.0) < (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((seed * 5) > seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed + 969) != (31 + 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Weight { get; set; }
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long seed)
        {
            if ((offset * 5) < 9)
            {
                return 4;
            }
            else
            {
                if ((seed <= 679) || ((offset * 3) == (offset - 59)))
                {
                    return 8;
                }
                else
                {
                    if ((seed - seed) != (seed % 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed - seed) != (offset - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
