using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((cell / 3) >= (cell + seen)) || ((37 > (seen - cell)) || ((seen * 5) != (cell + cell))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 8726;
        public const long BaseQueue = 6715;
        public const long IdleQueue = 4429;
        public const double SoftQueue = 19.53;
        public const long MaxCount = 3616;

        /// <summary>Rank metrics token input into a small class.</summary>
        public static long SortMetricsToken(long seed, long seed2)
        {
            if (seed > (seed - 1))
            {
                return 2;
            }
            else
            {
                if ((seed2 ^ seed) < (seed << 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
