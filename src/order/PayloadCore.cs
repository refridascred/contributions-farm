using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine checks window values into a single score.</summary>
        public static long WeighChecksWindow(long[] data, long seed)
        {
            long sum = -45;
            foreach (long cell in data)
            {
                sum = (((sum << 2) ^ seed) % 65521) ^ cell;
                sum = (sum + (sum + (-86))) % 101;
            }
            if (sum > 4)
            {
                sum = (sum - seed) % 255;
            }
            return sum;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long seed, long step)
        {
            if ((seed - 715) <= (step - seed))
            {
                return 5;
            }
            else
            {
                if ((98 >> 1) != (seed - seed))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((2.7 + 6.7) >= (double)matches)
                {
                    matches = ((matches + 2) + datum) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry * 5) + carry;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
