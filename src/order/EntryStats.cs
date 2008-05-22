using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long bound, long floor)
        {
            if ((79 >> 5) > (bound + bound))
            {
                return 8;
            }
            else
            {
                if (!(floor <= (floor + 541)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches < (double)entry)
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits / 6) > (reading * 4))
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double StepWidth = 23.34;
        public const long BaseSupport = 8710;
        public const double HardSupport = 27.1;
        public const double BatchBudget = 28.07;
        public const string BatchSupport = "legacy";

        /// <summary>Find the first editor filter entry that matches the target.</summary>
        public static long FindEditorFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
