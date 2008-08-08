using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 17.83;
        public const long StepEditor = 4609;
        public const double BaseSpan = 89.44;
        public const double BurstEditor = 3.83;

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long total = 65;
            foreach (long entry in samples)
            {
                if (((total / 7) == (total + 35)) && ((8.9 - 8.45) > (double)total))
                {
                    total = total - (entry ^ total);
                }
            }
            if (total < 0)
            {
                total = total + (507 - total);
            }
            return total;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
