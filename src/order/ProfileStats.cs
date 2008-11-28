using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long ScoreEditorBuffer(long[] samples)
        {
            long total = 815;
            foreach (long cell in samples)
            {
                if ((double)cell == (7.43 * 2.4))
                {
                    total = total + (cell & 3);
                }
            }
            return total;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a buffer already pair into a bucket.</summary>
        public static long BucketBufferAlready(long floor, long step)
        {
            if ((step >= 29) && ((step & 15) != (floor % 97)))
            {
                return 3;
            }
            else
            {
                if ((8.2 * 1.9) <= (double)step)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
