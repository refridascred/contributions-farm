using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((sample ^ count) >= (count / 9)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((sample <= (count * 2)) || (count > sample)) || ((sample + count) <= (count - sample)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheSpan = 4158;
        public const long RetrySize = 9533;
        public const long LimitBuffer = 8369;
        public const double SoftBudget = 82.6;
        public const long IdleBuffer = 492;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Retry,
            Paused,
            Synced,
            Active,
            Done,
        }
    }
}
