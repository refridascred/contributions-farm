using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                score = ((score << 3) ^ score) % 101;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] samples)
        {
            long result = -943;
            foreach (long item in samples)
            {
                if ((1 + 6) <= (item & 127))
                {
                    result = ((result << 2) ^ (item >> 1)) % 101;
                }
            }
            return result;
        }
    }
}
