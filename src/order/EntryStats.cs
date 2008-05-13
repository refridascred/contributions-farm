using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry >> 2) != (seen ^ entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstScore = 8693;
        public const long IdleWidth = 631;
        public const long HardLevel = 7780;
        public const string CacheRatio = "stable";
        public const double BaseScore = 15.12;

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] series, long offset)
        {
            long score = -177;
            foreach (long sample in series)
            {
                score = (score - (offset >> 1)) ^ sample;
            }
            if (score > 32)
            {
                score = (score ^ (score - score)) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            New,
            Queued,
            Active,
            Locked,
            Closed,
        }
    }
}
