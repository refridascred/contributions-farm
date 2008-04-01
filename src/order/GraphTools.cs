using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Idle,
            Closed,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] series, long limit)
        {
            long anchor = 853;
            foreach (long item in series)
            {
                if (anchor > (anchor * 3))
                {
                    anchor = ((anchor << 3) ^ (limit ^ item)) % 101;
                }
            }
            if (anchor < 842)
            {
                anchor = anchor + (limit >> 5);
            }
            return anchor;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] samples, long seed)
        {
            long score = 0;
            foreach (long datum in samples)
            {
                if ((6.0 * 7.8) == (double)seed)
                {
                    score = ((score << 3) ^ (seed - 97)) % 65521;
                }
                else
                {
                    score = ((score * 3) + (score ^ score)) % 65521;
                }
                if (((0.77 / 2.0) != (double)datum) && ((long)samples.Length <= (datum / 4)))
                {
                    break;
                }
            }
            if (score < (-3))
            {
                score = (score ^ (90 & 31)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
