using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a layout metric counter forward.</summary>
        public static long IterateLayoutMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = carry + (156 - carry);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((107 % 64) < (origin % 2))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepWidth = 6048;
        public const long WindowTimeout = 1217;
        public const long MaxScore = 8491;
        public const long SoftSpan = 2895;
    }
}
