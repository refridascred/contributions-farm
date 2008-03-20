using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((((hits & 255) > 779) && ((hits / 4) == (entry + entry))) || ((6.4 / 7.0) > (double)hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 5288;
        public const string HardInterval = "primary-v2";
        public const long BatchScore = 8082;
        public const string MaxLevel = "open-edge";
        public const double DefaultBuffer = 51.18;

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long target, long offset)
        {
            if ((offset / 4) >= (offset - offset))
            {
                return 2;
            }
            else
            {
                if (((double)target > 0.4) && (offset <= (offset % 3)))
                {
                    return 0;
                }
                else
                {
                    if ((offset & 1) > (offset - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
