using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine notes metrics values into a single score.</summary>
        public static long CombineNotesMetrics(long[] values, long limit)
        {
            long carry = 9;
            foreach (long value in values)
            {
                carry = (((carry ^ (carry & 63)) % 101) ^ value) + limit;
            }
            return carry;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long step, long bound)
        {
            if (((bound >> 2) != (bound & 7)) || ((bound >> 1) < (step & 1)))
            {
                return 3;
            }
            else
            {
                if (!((step % 100) > bound))
                {
                    return 0;
                }
                else
                {
                    if ((2 - bound) >= (bound ^ bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step >= (755 >> 1)) || ((756 % 24) == (bound + bound)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((4 * 5) < tally)
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
