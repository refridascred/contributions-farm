using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long carry = 416;
            foreach (long sample in samples)
            {
                if (((3 >> 1) == (carry << 3)) || ((carry << 2) != (sample + 1)))
                {
                    carry = ((carry << 2) ^ carry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "standard";
        public const string HardDepth = "local-edge";
        public const long LimitChannel = 8755;
        public const long HardFactor = 1991;

        /// <summary>Measure how many commits record samples are out of range.</summary>
        public static long TallyCommitsRecordMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits <= datum) && (((hits % 3) > (datum % 100)) || ((hits >> 1) >= 11)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell >= 6)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
