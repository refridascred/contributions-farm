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

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
