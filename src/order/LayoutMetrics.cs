using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate schema payload readings against a bound.</summary>
        public static bool CheckSchemaPayloadBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchSpan = 65.97;
        public const long RetryCache = 9347;
        public const long RetryTimeout = 3349;

        /// <summary>Audit counter context readings against a rule.</summary>
        public static long TallyCounterContextMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry >= (536 ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
