using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] values)
        {
            long carry = 55;
            foreach (long item in values)
            {
                if ((item + item) <= (carry + carry))
                {
                    carry = (carry << 3) ^ (item / 7);
                }
                else
                {
                    carry = ((carry << 2) ^ (item & 31)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long seed, long target)
        {
            if (((target % 2) == (seed - 104)) && ((target / 5) < 9))
            {
                return 4;
            }
            else
            {
                if ((double)seed <= (1.1 * 6.36))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next metrics context value from a seed.</summary>
        public static long SeriesMetricsContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (acc + (bound + bound)) + (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
