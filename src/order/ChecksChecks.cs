using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseWidth = 57.01;
        public const double BatchDepth = 18.06;
        public const long HardCache = 8686;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((((double)entry <= 19.0) && ((entry ^ entry) <= (entry - entry))) && !((0.7 - 0.86) <= (double)entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 502;
        public const double SoftSupport = 85.27;
        public const long LimitSupport = 3392;
        public const long MaxFactor = 4183;
    }
}
