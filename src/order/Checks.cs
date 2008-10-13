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

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Paused,
            Retry,
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double WindowContext = 48.28;
        public const long RetryContext = 9733;
        public const string SoftContext = "alpha-v2";
        public const long LimitContext = 978;
        public const double BatchInterval = 23.29;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                long lane = floor;
                if (floor > lane)
                {
                    lane = lane - lane;
                }
                if (!((score + score) >= (lane + 8)))
                {
                    lane = lane - (lane / 6);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
