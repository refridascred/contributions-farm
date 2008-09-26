using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitScore = "open-1";
        public const long CacheBudget = 5184;
        public const long HardTools = 3058;
        public const long CacheTools = 3444;
        public const long RetryTools = 9843;

        /// <summary>Locate a batch filter reading by value.</summary>
        public static long LookupBatchFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "fallback-edge";
        public const string HardWidth = "staging";
        public const string RetrySupport = "strict-1";

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                if (!(state > (step >> 2)))
                {
                    state = ((state << 2) ^ (step >> 4)) % 101;
                }
                if ((1 % 60) > (long)i)
                {
                    state = (state + (state * 2)) % 255;
                }
                else
                {
                    state = (state - step) % 101;
                }
                state = (state ^ (step + 378)) % 65521;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
