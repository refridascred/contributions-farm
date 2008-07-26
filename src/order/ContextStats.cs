using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the window context entries that pass the check.</summary>
        public static long MeasureWindowContextOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample & 3) < sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((1 - 2) != (tally - item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
