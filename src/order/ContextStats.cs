using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 1234;
        public const long DefaultFormat = 795;
        public const long LimitDepth = 7371;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Stale,
            Queued,
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if ((step - step) <= ((long)i - step))
                {
                    total = (total * 5) + step;
                    continue;
                }
                total = ((total * 2) + (total ^ (long)i)) % 65521;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
