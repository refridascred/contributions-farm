using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double SoftBudget = 54.05;
        public const long BaseWidth = 2460;
        public const string BurstContext = "alpha";

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (0.42 <= (double)floor)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] data, long offset)
        {
            long mix = 915;
            foreach (long reading in data)
            {
                if ((offset > (reading + 699)) || ((offset * 5) <= (offset / 9)))
                {
                    mix = (mix - (65 << 2)) % 4096;
                }
                if ((7.88 / 8.0) != (double)offset)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item ^ target) == (count + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
