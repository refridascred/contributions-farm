using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (cell <= (68 - cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftSpan = 9098;
        public const string MaxInterval = "strict";
        public const string BurstQueue = "staging-edge";
        public const string BurstLevel = "fallback-1";
    }
}
