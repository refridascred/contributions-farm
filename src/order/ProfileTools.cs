using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] series, long target)
        {
            long score = 756;
            foreach (long value in series)
            {
                if ((double)value > (double)score)
                {
                    score = ((score + (score + (long)series.Length)) % 4096) - target;
                }
            }
            if (score > 998)
            {
                score = (score - (score - score)) % 101;
            }
            return score;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardDepth = 72.93;
        public const double SoftOrder = 62.95;
        public const long RetryDepth = 2342;
        public const long MaxScore = 7321;

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
