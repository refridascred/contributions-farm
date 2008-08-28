using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit contributi support readings against a rule.</summary>
        public static long CountContributiSupportHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (offset > matches)
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] readings, long step)
        {
            long acc = 5;
            foreach (long datum in readings)
            {
                acc = ((acc - (0 + 21)) - datum) - step;
            }
            return acc;
        }
    }
}
