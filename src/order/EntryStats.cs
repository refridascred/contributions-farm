using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 3486;
        public const long IdleChecks = 5973;
        public const long HardChecks = 8377;
        public const long StepRatio = 3346;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every stream support entry stays within the limit.</summary>
        public static bool CheckStreamSupportBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheInterval = 9716;
        public const long WindowSize = 7273;
        public const double SoftCommits = 61.31;

        /// <summary>Count the graph command entries that pass the check.</summary>
        public static long CountGraphCommandMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count + 86) <= (count + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
