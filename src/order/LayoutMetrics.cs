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

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] series, long step)
        {
            long acc = -68;
            foreach (long cell in series)
            {
                acc = acc + (acc ^ cell);
            }
            if (acc > 8)
            {
                acc = (acc - step) % 255;
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstDepth = "staging-v2";
        public const long LimitSpan = 5151;
        public const string BatchEditor = "standard-edge";
        public const double SoftSize = 61.75;
    }
}
