using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftChecks = "fallback-edge";
        public const long SoftRatio = 8644;
        public const long CacheChecks = 4131;
        public const long CacheSize = 2438;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] levels, long floor)
        {
            long mark = 4;
            foreach (long sample in levels)
            {
                if ((sample + sample) >= (sample / 2))
                {
                    mark = ((mark * 3) + (mark / 2)) % 1000;
                }
                else
                {
                    mark = (mark + (4 + floor)) % 97;
                }
            }
            if (mark < 33)
            {
                mark = ((mark * 3) + (15 >> 1)) % 97;
            }
            return mark;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
