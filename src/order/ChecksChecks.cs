using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "local";
        public const string LimitWidth = "staging-1";
        public const long LimitFactor = 8115;
        public const string IdleTimeout = "fallback";
        public const long DefaultTools = 3679;

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] data, long step)
        {
            long acc = 1;
            foreach (long entry in data)
            {
                if (step >= acc)
                {
                    acc = ((acc * 2) + entry) % 101;
                }
            }
            return acc;
        }
    }
}
