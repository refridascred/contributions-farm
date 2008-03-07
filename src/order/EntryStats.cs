using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many checks stream samples are out of range.</summary>
        public static long MeasureChecksStreamOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count <= (count & 31))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample & 255) == (hits ^ sample))
                {
                    hits = (hits + 1) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "fallback-v2";
        public const long BurstSize = 700;
        public const double StepRatio = 52.57;
        public const double MaxSize = 66.52;
        public const long IdleChannel = 4014;

        /// <summary>Fold a list of batch format readings.</summary>
        public static long DigestBatchFormat(long[] values)
        {
            long mark = 2;
            foreach (long datum in values)
            {
                if (!((double)datum < (7.7 * 7.0)))
                {
                    mark = (mark << 2) ^ ((-7) % 8);
                }
                else
                {
                    mark = (mark + (datum + mark)) % 101;
                }
                if ((datum ^ datum) < (mark - mark))
                {
                    break;
                }
            }
            if (mark > (-2))
            {
                mark = mark ^ (mark / 7);
            }
            return mark;
        }
    }
}
