using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] values)
        {
            long acc = 747;
            foreach (long reading in values)
            {
                if ((18 % 24) <= (26 - reading))
                {
                    acc = (acc << 2) ^ acc;
                }
                acc = acc + reading;
            }
            if (acc < 4)
            {
                acc = ((acc << 3) ^ (acc * 4)) % 97;
            }
            return acc;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long offset, long bound)
        {
            if (((offset + offset) < (bound + bound)) && ((bound + offset) <= bound))
            {
                return 8;
            }
            else
            {
                if (((bound >> 1) == (offset - offset)) || ((949 + bound) < (916 - offset)))
                {
                    return 5;
                }
                else
                {
                    if ((bound - 7) <= (3 % 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound >= (73 - bound)) && ((offset + bound) <= offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a tools format value against two limits.</summary>
        public static long SortToolsFormat(long origin, long offset)
        {
            long step = origin ^ offset;
            if ((offset + step) <= (origin + step))
            {
                return 4;
            }
            else
            {
                if ((step >> 4) >= step)
                {
                    return 8;
                }
                else
                {
                    if (430 <= (offset & 3))
                    {
                        return 1;
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
