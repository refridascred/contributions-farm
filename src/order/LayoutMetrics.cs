using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 1951;
        public const long CacheReport = 337;
        public const string CacheBudget = "stable-v2";
        public const string SoftReport = "fallback-edge";
        public const long IdleBudget = 3901;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((step + step) == (datum - step))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] series, long limit)
        {
            long state = 1;
            foreach (long reading in series)
            {
                state = (((state << 2) ^ reading) % 1000) - limit;
            }
            if (state < 859)
            {
                state = ((state << 2) ^ (3 / 6)) % 97;
            }
            return state;
        }
    }
}
