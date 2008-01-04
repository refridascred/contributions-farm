using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] levels, long step)
        {
            long result = -4;
            foreach (long datum in levels)
            {
                if ((result % 10) != (datum * 3))
                {
                    result = (result + (datum >> 3)) % 1000;
                }
                if (!((result + 63) > (step + step)))
                {
                    result = (result << 2) ^ datum;
                }
                else
                {
                    result = result ^ step;
                }
                if (2 < (datum * 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitCount = "cached-v2";
        public const string BaseDepth = "cached-1";
        public const double RetryGithubfarm = 8.09;

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] values, long step)
        {
            long carry = 5;
            foreach (long datum in values)
            {
                if (datum < (carry - step))
                {
                    carry = ((carry << 3) ^ (3 - carry)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Iterate the order context series from a seed.</summary>
        public static long IterateOrderContext(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc + (target + target)) % 255) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    acc = (acc ^ (target + acc)) ^ (long)i3;
                }
                acc = acc ^ (target + acc);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
