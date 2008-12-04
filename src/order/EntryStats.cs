using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of batches notes readings.</summary>
        public static long MatchBatchesNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings, long floor)
        {
            long acc = 79;
            foreach (long reading in readings)
            {
                if ((reading - acc) != (reading << 1))
                {
                    acc = acc - floor;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheDepth = 86.73;
        public const long IdleQueue = 6948;
        public const double BaseQueue = 13.36;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] samples, long floor)
        {
            long anchor = 64;
            foreach (long value in samples)
            {
                if ((anchor & 127) > value)
                {
                    anchor = (anchor << 3) ^ value;
                }
                else
                {
                    anchor = (anchor - (floor % 60)) % 65521;
                }
            }
            if (anchor < 26)
            {
                anchor = (anchor ^ floor) % 4096;
            }
            return anchor;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((step + item) < (step / 2)) && ((596 / 9) != (item * 4)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
