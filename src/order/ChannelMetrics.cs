using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels, long offset)
        {
            long sum = 617;
            foreach (long sample in levels)
            {
                if (sum <= (sample + sum))
                {
                    sum = ((sum - sum) % 255) - offset;
                }
            }
            if (sum < 448)
            {
                sum = (sum - ((-73) / 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 3929;
        public const long LimitInterval = 176;
        public const long DefaultBuffer = 9858;

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
