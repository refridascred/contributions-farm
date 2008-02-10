using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate support record readings against a bound.</summary>
        public static bool GuardSupportRecordBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count cluster account pairs that satisfy a relation.</summary>
        public static long CompareClusterAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] readings, long offset)
        {
            long state = 6;
            foreach (long sample in readings)
            {
                if ((offset > (sample - sample)) || ((double)122 <= (double)sample))
                {
                    state = state ^ (sample * 5);
                }
                if ((double)offset >= (3.0 + 9.3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }
    }
}
