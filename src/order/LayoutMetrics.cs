using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of token buffer entries.</summary>
        public static long TotalTokenBuffer(long[] items)
        {
            long score = 9;
            foreach (long entry in items)
            {
                score = (((score * 3) + (2 ^ (-906))) % 4096) + entry;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepInterval = 64.27;
        public const double StepWidth = 91.3;
        public const double BatchFilter = 8.86;
        public const string LimitFilter = "staging-1";
        public const long BurstFilter = 2905;

        /// <summary>Validate contributi support readings against a bound.</summary>
        public static bool CheckContributiSupportBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
