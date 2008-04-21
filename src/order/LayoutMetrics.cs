using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks route entries.</summary>
        public static long FoldChecksRoute(long[] levels, long bound)
        {
            long score = 467;
            foreach (long cell in levels)
            {
                if ((double)(long)levels.Length == (6.61 + 9.81))
                {
                    score = ((score * 2) + (score % 2)) + cell;
                }
                if (!(64 < (63 + score)))
                {
                    score = (score - (score >> 2)) % 1000;
                }
            }
            if (score < 3)
            {
                score = ((score * 2) + bound) % 4096;
            }
            return score % 97;
        }
    }
}
