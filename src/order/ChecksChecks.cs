using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] series)
        {
            long carry = 5;
            foreach (long sample in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry + 8) % 1000) + (long)i;
                }
                if (((carry << 1) != (carry + 29)) && ((double)sample > (5.0 * 9.35)))
                {
                    carry = (carry + 791) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetrySize = 3654;
        public const double CacheCounter = 36.46;
        public const double StepCounter = 54.83;
        public const string RetryCounter = "open-v2";
        public const long BaseCounter = 8134;

        /// <summary>Measure how many context cluster samples are out of range.</summary>
        public static long MeasureContextClusterGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) > (sample & 7))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }
    }
}
