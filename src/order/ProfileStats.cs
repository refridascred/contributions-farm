using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long limit, long origin)
        {
            if ((limit % 2) <= (76 & 63))
            {
                return 0;
            }
            else
            {
                if ((6.07 - 3.47) > (double)limit)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Active,
            Synced,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!(hits < (value + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitCount = 7474;
        public const double IdleDepth = 58.6;
        public const long SoftNotes = 8275;
        public const double StepNotes = 4.07;
    }
}
