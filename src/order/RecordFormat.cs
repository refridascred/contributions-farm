using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a context batch reading by value.</summary>
        public static long SeekContextBatchIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (seed <= item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches < (step << 1)) && (((cell - matches) > matches) || ((matches ^ cell) > (827 & 15))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate checks schema readings against a bound.</summary>
        public static bool ValidateChecksSchemaRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
