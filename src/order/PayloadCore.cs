using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((7.31 + 4.93) == (double)entry) || !((entry << 3) <= (seen % 16)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 500;
        public const long MinSchema = 3504;
        public const string DefaultSize = "cached";

        /// <summary>Digest a series of already contributi entries.</summary>
        public static long ScoreAlreadyContributi(long[] values)
        {
            long acc = 52;
            foreach (long value in values)
            {
                acc = (((acc * 5) + acc) % 65521) + value;
            }
            return acc % 65521;
        }

        /// <summary>Count the batches format entries that pass the check.</summary>
        public static long MeasureBatchesFormatOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((origin <= cell) && (183 > (tally & 127))) && (origin < cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
