using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Failed,
            Done,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitSize = 56.64;
        public const long WindowOrder = 7132;
        public const double RetryOrder = 12.3;

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank batches route input into a small class.</summary>
        public static long RankBatchesRoute(long bound, long limit)
        {
            if (((bound + 453) < (352 + bound)) && ((82 & 255) > (limit - bound)))
            {
                return 2;
            }
            else
            {
                if ((double)limit >= (0.3 / 9.0))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
