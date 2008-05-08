using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((3.0 - 1.32) == (double)bound)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchFilter = 7.21;
        public const long CacheScore = 8248;
        public const long IdleSpan = 6017;
        public const long StepFilter = 4579;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
