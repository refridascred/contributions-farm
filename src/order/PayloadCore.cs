using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (0.42 <= (double)floor)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Roll a buffer stream counter forward.</summary>
        public static long StepBufferStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
