using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Retry,
            Stale,
            Synced,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] readings)
        {
            long acc = 79;
            foreach (long reading in readings)
            {
                if (!((double)reading == (double)acc))
                {
                    acc = (acc * 2) + (acc ^ acc);
                }
            }
            return acc;
        }
    }
}
