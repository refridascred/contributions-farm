using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stream context pair into a bucket.</summary>
        public static long SortStreamContext(long offset, long target)
        {
            if ((((-67) - target) >= (offset * 2)) && ((0.07 + 2.2) > (double)target))
            {
                return 6;
            }
            else
            {
                if (offset >= (target << 2))
                {
                    return 2;
                }
                else
                {
                    if ((target - offset) > offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Queued,
            Dropped,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "staging-v2";
        public const long MinRoute = 4097;
        public const double HardLevel = 91.37;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
