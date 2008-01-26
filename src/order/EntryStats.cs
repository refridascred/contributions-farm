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

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Ready,
            Stale,
            Done,
            Idle,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
