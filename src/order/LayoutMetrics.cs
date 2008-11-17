using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardDepth = 5.85;
        public const long IdleLayout = 6290;
        public const long IdleLevel = 349;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long limit, long seed)
        {
            if (((-534) / 6) > limit)
            {
                return 7;
            }
            else
            {
                if (!((limit - seed) >= limit))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count report record pairs that satisfy a relation.</summary>
        public static long MatchReportRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
