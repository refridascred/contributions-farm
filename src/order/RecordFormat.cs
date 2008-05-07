using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (sample >= (sample + sample))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Compare every pair of order batch readings.</summary>
        public static long CompareOrderBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Ready,
            Locked,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((matches % 60) <= (entry ^ matches)) || ((entry >> 2) > (matches % 100))) && (((3.2 + 3.46) >= (double)matches) && ((double)entry != (double)matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
