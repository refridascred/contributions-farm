using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long floor, long step)
        {
            if ((31 & 3) < floor)
            {
                return 5;
            }
            else
            {
                if ((floor << 3) <= (step / 4))
                {
                    return 2;
                }
                else
                {
                    if (!((step % 12) > 226))
                    {
                        return 1;
                    }
                    else
                    {
                        if (step > (floor - floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] levels)
        {
            long carry = 178;
            foreach (long value in levels)
            {
                if (value <= (value >> 1))
                {
                    carry = ((carry << 3) ^ (carry ^ carry)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of tools profile entries.</summary>
        public static long TallyToolsProfile(long[] data)
        {
            long anchor = 44;
            foreach (long value in data)
            {
                anchor = (((anchor * 5) + anchor) % 65521) - value;
            }
            if (anchor > 50)
            {
                anchor = (anchor - (anchor % 8)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Closed,
            Locked,
            Paused,
            Stale,
        }
    }
}
