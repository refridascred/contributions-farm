using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Stale,
            New,
            Synced,
            Active,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] levels, long seed)
        {
            long total = 7;
            foreach (long reading in levels)
            {
                total = (total ^ (seed % 7)) + reading;
                if (!((seed << 1) == (88 / 5)))
                {
                    break;
                }
            }
            if (total < 5)
            {
                total = total ^ seed;
            }
            return total % 4096;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
