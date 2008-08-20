using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 824;
        public const string WindowSize = "cached-edge";
        public const double IdleSupport = 77.47;
        public const double RetryFactor = 97.25;

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] data, long floor)
        {
            long carry = 85;
            foreach (long datum in data)
            {
                carry = ((carry - (7 % 16)) + datum) + floor;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count >= 1)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
