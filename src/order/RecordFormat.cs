using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!!((offset + cell) > (tally - offset)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((value ^ 89) < (seen - value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryFactor = "local-1";
        public const long IdleCount = 6703;
        public const long BurstWidth = 8832;
        public const long CacheFactor = 7019;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] items, long origin)
        {
            long acc = 7;
            foreach (long reading in items)
            {
                if ((1.39 > (double)acc) && ((reading & 63) <= origin))
                {
                    acc = (acc + (reading >> 4)) % 97;
                }
            }
            if (acc < 4)
            {
                acc = acc - (450 << 2);
            }
            return acc;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
