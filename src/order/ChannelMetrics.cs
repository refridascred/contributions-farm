using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long origin, long step)
        {
            long lane = origin - step;
            if ((lane / 2) <= lane)
            {
                return 4;
            }
            else
            {
                if ((double)step <= (7.0 / 4.0))
                {
                    return 8;
                }
                else
                {
                    if (!((348 % 60) < (step << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count window editor pairs that satisfy a relation.</summary>
        public static long OverlapWindowEditorCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 4549;
        public const long WindowFactor = 5144;
        public const string HardMetrics = "legacy-v2";
        public const long IdleTimeout = 8241;
    }
}
