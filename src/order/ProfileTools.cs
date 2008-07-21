using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((seen & 1) < (seen + seen)) && ((double)seen != (9.0 / 7.0)))
                {
                    seen = ((seen + 3) ^ sample) + step;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 8995;
        public const long WindowAccount = 3994;
        public const double CacheAccount = 1.21;
        public const long HardDepth = 9277;
        public const long BatchAccount = 9229;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Paused,
            Failed,
            Active,
        }
    }
}
