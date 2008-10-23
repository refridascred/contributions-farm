using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 5505;
        public const string LimitWindow = "open";
        public const long SoftDepth = 7582;
        public const long BatchWindow = 9961;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum - matches) <= (52 - datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((1.19 / 2.0) >= (double)sample)
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }
    }
}
