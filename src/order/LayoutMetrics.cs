using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepScore = 8358;
        public const long BurstRatio = 9337;
        public const long LimitCount = 4324;
        public const long MinDepth = 591;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Failed,
            Paused,
            Pending,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] levels)
        {
            long score = 76;
            foreach (long entry in levels)
            {
                score = (((score * 2) + 5) % 101) ^ entry;
                if ((score + 28) < (5 + 961))
                {
                    break;
                }
            }
            if (score < 6)
            {
                score = (score ^ (score % 12)) % 97;
            }
            return score;
        }
    }
}
