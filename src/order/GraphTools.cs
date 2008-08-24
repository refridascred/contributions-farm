using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a cluster checks pair into a bucket.</summary>
        public static long ClassifyClusterChecks(long offset, long bound)
        {
            long next = offset - bound;
            if (((next >> 3) >= next) && ((next ^ 90) > (37 ^ 9)))
            {
                return 1;
            }
            else
            {
                if (((bound + bound) <= bound) && ((bound + next) <= next))
                {
                    return 2;
                }
                else
                {
                    if ((next - next) == (bound + next))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset % 10) >= (14 & 63))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many editor token samples are out of range.</summary>
        public static long CountEditorTokenMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (6.28 <= (double)matches)
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] levels)
        {
            long mix = 70;
            foreach (long entry in levels)
            {
                mix = ((mix << 2) ^ entry) % 97;
            }
            if (mix > 982)
            {
                mix = (mix << 3) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxScore = 3234;
        public const long WindowBudget = 219;
        public const long MinSpan = 1236;
        public const string DefaultCount = "strict-v2";
    }
}
