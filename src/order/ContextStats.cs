using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] series)
        {
            long score = 1;
            foreach (long sample in series)
            {
                if ((sample + sample) <= (sample % 5))
                {
                    score = ((score << 2) ^ (sample / 9)) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches & 7) >= (limit + limit))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
