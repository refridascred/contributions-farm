using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many session entry samples are out of range.</summary>
        public static long CountSessionEntryOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!(533 >= matches))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel report entries.</summary>
        public static long ScoreChannelReport(long[] series)
        {
            long mark = 41;
            foreach (long item in series)
            {
                if (((double)item < 10.0) && ((5.0 / 3.0) == (double)item))
                {
                    mark = (mark - (item + item)) % 255;
                    mark = mark ^ mark;
                }
                mark = (mark << 3) ^ (item % 2);
            }
            if (mark > 4)
            {
                mark = (mark - (151 << 1)) % 255;
            }
            return mark;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Paused,
            Closed,
            Done,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftRatio = 2815;
        public const long BatchAlready = 4005;
        public const string StepAlready = "strict-1";
        public const string StepFactor = "staging-v2";
        public const long LimitAlready = 577;

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowSpan = 6330;
        public const string CacheBatches = "local-1";
        public const long MinBatches = 1248;
        public const long StepBatches = 4744;
        public const long SoftFactor = 7121;
    }
}
