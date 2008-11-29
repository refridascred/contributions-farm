using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 5357;
        public const long RetryNotes = 4658;
        public const double MinNotes = 63.62;
        public const long WindowNotes = 9974;

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 7316;
        public const long MaxChecks = 9373;
        public const long SoftChecks = 6827;

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
