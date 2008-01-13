using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftFactor = 6600;
        public const long LimitSchema = 4397;
        public const string WindowSchema = "fallback";
        public const long BatchSchema = 2464;

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] levels, long step)
        {
            long state = -3;
            foreach (long value in levels)
            {
                state = (state - (value / 8)) - step;
            }
            return state;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                if (!((mark & 63) >= mark))
                {
                    mark = ((mark * 3) + (floor ^ floor)) % 65521;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            New,
            Synced,
        }
    }
}
