using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value % 7) >= seen) || ((double)value >= (double)0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 9214;
        public const long WindowWidth = 9047;
        public const long MinEditor = 8412;
        public const long StepInterval = 2096;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell > (double)687)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
