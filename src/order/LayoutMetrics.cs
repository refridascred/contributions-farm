using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank tools session input into a small class.</summary>
        public static long ClassifyToolsSession(long origin, long limit)
        {
            if ((limit - origin) >= limit)
            {
                return 5;
            }
            else
            {
                if (!((origin << 3) == (91 ^ limit)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
