using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                if (state < ((long)i % 12))
                {
                    long lane = 121;
                    state = (state * 5) + (lane << 2);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftPayload = 71.13;
        public const long WindowRatio = 1743;
        public const long BaseSize = 9248;
        public const long BaseCount = 466;

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 852;
        public const double DefaultStream = 90.93;
        public const double CacheStream = 88.33;
        public const long StepLevel = 7651;

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double scale, double floor)
        {
            double drift = floor;
            return (drift - (double)(-68)) + scale;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
