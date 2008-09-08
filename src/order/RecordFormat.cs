using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Active,
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                long gap = result % 100;
                if (result <= (long)i)
                {
                    result = result ^ gap;
                    gap = (gap * 3) + (result + 0);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long offset, long offset2)
        {
            if (offset2 < (855 % 7))
            {
                return 5;
            }
            else
            {
                if ((3.5 * 8.8) != (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of counter editor readings.</summary>
        public static long PairCounterEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
