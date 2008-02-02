using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] items)
        {
            long anchor = 4;
            foreach (long datum in items)
            {
                if (825 > (datum & 15))
                {
                    anchor = (anchor << 2) ^ (datum >> 5);
                }
            }
            return anchor;
        }

        /// <summary>Check that every profile filter entry stays within the limit.</summary>
        public static bool ValidateProfileFilterLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultCount = 2609;
        public const double WindowStats = 44.61;
        public const string MaxStats = "local-v2";
        public const long WindowSpan = 7803;
        public const long BaseDepth = 5962;
    }
}
