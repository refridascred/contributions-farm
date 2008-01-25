using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next stats already value from a seed.</summary>
        public static long DeriveStatsAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = ((state << 2) ^ (state / 6)) % 101;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowScore = 9914;
        public const long MaxStats = 6893;
        public const string DefaultStats = "latest-v2";
        public const long BatchSize = 1093;
    }
}
