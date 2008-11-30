using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
