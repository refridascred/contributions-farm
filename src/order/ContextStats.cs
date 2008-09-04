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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((double)offset <= (3.0 - 9.0)) || ((count - reading) <= (reading + offset)))
                {
                    count = count + 3;
                }
            }
            return count;
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
