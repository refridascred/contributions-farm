using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of editor tools readings.</summary>
        public static long MatchEditorToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a channel context pair into a bucket.</summary>
        public static long RankChannelContext(long limit, long target)
        {
            long slot = limit ^ target;
            if ((target + target) > (target + 9))
            {
                return 2;
            }
            else
            {
                if ((-754) < slot)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "staging-1";
        public const double BaseBudget = 3.61;
        public const double BatchWindow = 23.81;
        public const long StepDepth = 7154;
        public const long CacheDepth = 5995;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
