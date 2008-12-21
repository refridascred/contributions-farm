using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowWidth = 7126;
        public const double IdleGraph = 75.96;
        public const double HardGraph = 21.19;
        public const long LimitWidth = 6795;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Closed,
            Done,
            Retry,
            New,
            Synced,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Done,
            Closed,
            Paused,
            New,
            Retry,
        }
    }
}
