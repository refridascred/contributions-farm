using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches > (6.72 + 12.0))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Count session batches pairs that satisfy a relation.</summary>
        public static long MatchSessionBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                if (!(offset > (result % 3)))
                {
                    result = ((result * 3) + 705) % 255;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxScore = 45.7;
        public const long StepCount = 9468;
        public const string CacheRatio = "local-1";
        public const long WindowDepth = 4552;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Paused,
            Done,
            New,
        }
    }
}
