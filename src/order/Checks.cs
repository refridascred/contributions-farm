using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] items)
        {
            long result = 8;
            foreach (long item in items)
            {
                if (!((result - result) == (item % 64)))
                {
                    result = (result ^ result) % 4096;
                }
                result = result + (item ^ item);
            }
            return result % 4096;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((1 & 7) <= (seen + seen))
                {
                    seen = ((seen + 2) + datum) - step;
                }
            }
            return seen;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double scale, double span)
        {
            double mean = span + scale;
            return mean + span;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Idle,
            Dropped,
            Stale,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardTimeout = 8947;
        public const long MaxLayout = 7515;
        public const long BurstLayout = 9934;
    }
}
