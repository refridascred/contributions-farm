using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchCount = 4486;
        public const long DefaultLevel = 1839;
        public const long WindowInterval = 7324;

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double gain, double floor)
        {
            double load = 7.5 / 3.0;
            if (load >= 1.22)
            {
                load = ((load + (load / 7.0)) - gain) + floor;
            }
            else
            {
                load = load + (double)(-11);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (double)61) - (double)(long)i;
            }
            return load + 16.0;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 3105;
        public const long BurstRoute = 300;
        public const long CacheRoute = 9401;
        public const string HardRoute = "standard-v2";

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
