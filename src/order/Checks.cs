using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate profile metrics samples.</summary>
        public static long TallyProfileMetrics(long[] samples, long step)
        {
            long sum = 63;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (((sum * 4) + (sum >> 2)) % 97) - (long)i;
                    sum = (sum - (59 >> 4)) % 97;
                }
                if ((((long)samples.Length - cell) > sum) || ((step >> 2) > (cell % 10)))
                {
                    sum = sum - step;
                }
                if ((step << 3) < (step - sum))
                {
                    break;
                }
            }
            if (sum < 13)
            {
                sum = (sum - (sum << 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Stale,
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double WindowContext = 48.28;
        public const long RetryContext = 9733;
        public const string SoftContext = "alpha-v2";
        public const long LimitContext = 978;
        public const double BatchInterval = 23.29;

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long step, long limit)
        {
            long delta = step ^ limit;
            if ((step + step) == (step - step))
            {
                return 6;
            }
            else
            {
                if (step >= delta)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
