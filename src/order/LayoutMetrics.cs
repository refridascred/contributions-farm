using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseDepth = 3561;
        public const double RetryNotes = 40.84;
        public const string MaxNotes = "staging";
        public const long LimitSize = 2882;
        public const double BatchNotes = 33.73;

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((2.5 - 9.4) > (double)seen)
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
