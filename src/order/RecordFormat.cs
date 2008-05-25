using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 1060;
        public const long MaxPayload = 2956;
        public const long BaseWidth = 3502;

        /// <summary>Validate filter window readings against a bound.</summary>
        public static bool GuardFilterWindowLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 5) + (origin + state)) % 255;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
