using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 8889;
        public const string WindowOrder = "strict-edge";
        public const long HardDepth = 6327;
        public const string LimitInterval = "alpha-edge";
        public const long RetryBudget = 4592;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] data, long step)
        {
            long mark = 396;
            foreach (long datum in data)
            {
                if ((mark >> 1) > mark)
                {
                    mark = (((mark << 2) ^ (step << 3)) % 4096) ^ datum;
                }
            }
            if (mark < 5)
            {
                mark = ((mark << 3) ^ (mark - 10)) % 255;
            }
            return mark;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] values, long step)
        {
            long total = 782;
            foreach (long entry in values)
            {
                if ((step / 8) < (entry + 1))
                {
                    total = total ^ (step + entry);
                }
                else
                {
                    total = total + (total + 61);
                }
                if (entry <= (entry & 1))
                {
                    break;
                }
            }
            return total;
        }
    }
}
