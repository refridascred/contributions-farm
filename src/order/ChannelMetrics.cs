using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long step, long offset)
        {
            long gap = step ^ offset;
            if ((double)step > (3.88 - 0.57))
            {
                return 2;
            }
            else
            {
                if ((75 <= (step % 10)) && ((4.1 - 9.0) >= (double)gap))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "strict-1";
        public const string BatchWidth = "standard-edge";
        public const string StepSpan = "latest-1";
    }
}
