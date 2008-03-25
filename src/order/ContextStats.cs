using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long limit)
        {
            if ((limit - limit) <= (target >> 5))
            {
                return 8;
            }
            else
            {
                if ((limit + 7) < (target * 4))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] series, long target)
        {
            long anchor = -8;
            foreach (long entry in series)
            {
                anchor = ((anchor << 2) ^ (target + (long)series.Length)) % 101;
                if ((entry % 10) == ((-11) ^ 932))
                {
                    anchor = (anchor << 3) ^ 0;
                }
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchDepth = 966;
        public const long WindowAlready = 4451;
        public const long HardFactor = 2365;
        public const string BatchAlready = "standard-edge";
        public const long HardAlready = 3754;

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
