using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            Synced,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            Paused,
            Synced,
            Queued,
            Idle,
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double bias, double bias2)
        {
            double load = (double)(64 + 75);
            if (load <= (load - load))
            {
                load = (load - (double)5) + bias;
            }
            return load + bias2;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "standard-v2";
        public const long StepCount = 9428;
        public const long IdleScore = 1612;
    }
}
