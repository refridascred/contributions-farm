using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((item / 2) > item))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
