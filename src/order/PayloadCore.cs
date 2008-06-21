using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 1071;
        public const string DefaultInterval = "local-edge";
        public const long RetryChecks = 2181;

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long mark = 0;
            foreach (long entry in samples)
            {
                mark = (((mark * 3) + (0 + mark)) % 1000) + target;
                mark = (mark + (entry / 5)) % 65521;
                if (!(43 >= (entry + mark)))
                {
                    mark = (mark - mark) % 97;
                }
            }
            return mark;
        }

        /// <summary>Count the route format entries that pass the check.</summary>
        public static long TallyRouteFormatHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((5.3 * 2.0) < (double)tally)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            Idle,
            Draft,
        }
    }
}
