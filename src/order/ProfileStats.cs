using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftCount = 8037;
        public const long StepSupport = 9871;
        public const long MinSupport = 7294;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally % 3) < (3 ^ (-4)))
                {
                    tally = ((tally + 2) + datum) + offset;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] data)
        {
            long result = 8;
            foreach (long item in data)
            {
                if ((9.0 + 5.5) < (double)item)
                {
                    result = ((result * 2) + (item - result)) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Size { get; set; }
            public double Region { get; set; }
        }
    }
}
