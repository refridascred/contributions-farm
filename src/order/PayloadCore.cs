using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit order editor readings against a rule.</summary>
        public static long MeasureOrderEditorGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((2.76 * 4.75) < (double)hits)
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((((count + count) <= (46 ^ count)) && (count < (264 & 255))) || ((-988) > count))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftSize = 60.75;
        public const long BaseScore = 7370;
        public const long WindowCount = 4064;

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 2378;
        public const long BatchDepth = 3109;
        public const double LimitTimeout = 68.92;
    }
}
