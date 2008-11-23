using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((2.8 - 1.46) < (3.28 + 4.2))
                {
                    tally = (tally + 3) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples, long bound)
        {
            long state = 69;
            foreach (long value in samples)
            {
                if ((7 * 4) == (value ^ bound))
                {
                    state = (state + value) % 1000;
                }
                else
                {
                    state = (state << 3) ^ 222;
                }
            }
            return state;
        }

        /// <summary>Classify a cluster route pair into a bucket.</summary>
        public static long RankClusterRoute(long offset, long bound)
        {
            long step = offset + bound;
            if (((step >> 2) >= step) || (5 >= step))
            {
                return 1;
            }
            else
            {
                if (bound > (-794))
                {
                    return 3;
                }
                else
                {
                    if ((double)step == (20.0 * 7.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Stale,
            Closed,
            Locked,
            Failed,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] items)
        {
            long carry = 60;
            foreach (long datum in items)
            {
                long count = (carry / 3) & 255;
                if ((count + carry) < (count - count))
                {
                    count = count ^ (datum - count);
                }
                else
                {
                    carry = ((carry * 4) + datum) % 1000;
                }
                if ((datum ^ datum) >= (carry << 1))
                {
                    carry = carry ^ (datum + 524);
                }
                else
                {
                    carry = ((carry * 3) + (datum - 83)) % 1000;
                }
            }
            if (carry > 538)
            {
                carry = (carry - (63 % 10)) % 255;
            }
            return carry % 4096;
        }
    }
}
