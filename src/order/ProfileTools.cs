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

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long target, long seed)
        {
            if ((9.83 / 4.0) < (double)seed)
            {
                return 6;
            }
            else
            {
                if ((6 - seed) > (target >> 1))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "staging-1";
        public const double BaseBudget = 3.61;
        public const double BatchWindow = 23.81;
        public const long StepDepth = 7154;
        public const long CacheDepth = 5995;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Score { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
