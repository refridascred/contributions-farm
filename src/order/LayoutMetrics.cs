using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels, long floor)
        {
            long mark = 99;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ 89) + reading) + floor;
            }
            if (mark > 92)
            {
                mark = (mark ^ (mark * 3)) % 101;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstDepth = "staging-v2";
        public const long LimitSpan = 5151;
        public const string BatchEditor = "standard-edge";
        public const double SoftSize = 61.75;
    }
}
