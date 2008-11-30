using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] values)
        {
            long mix = 5;
            foreach (long sample in values)
            {
                if (((32 >> 3) <= sample) || ((double)mix <= (9.1 * 12.0)))
                {
                    mix = (mix - sample) % 1000;
                }
                else
                {
                    mix = mix ^ 59;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultBudget = 9341;
        public const long CacheInterval = 7148;
        public const double HardWidth = 14.71;
        public const long IdleCount = 3618;
    }
}
