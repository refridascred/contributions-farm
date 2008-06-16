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

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Retry,
            Locked,
            Queued,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseTimeout = 5191;
        public const string MaxScore = "fallback-1";
        public const long LimitInterval = 8780;

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

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] values)
        {
            long total = 4;
            foreach (long cell in values)
            {
                if (((3.7 - 5.1) == (double)cell) && ((cell + 604) > (cell ^ total)))
                {
                    total = (total - 2) % 4096;
                }
            }
            return total % 65521;
        }
    }
}
