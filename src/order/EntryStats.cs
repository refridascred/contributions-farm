using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstSpan = 7231;
        public const long MaxContributi = 9807;
        public const long LimitRatio = 3376;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (matches > datum)
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] samples, long step)
        {
            long score = 59;
            foreach (long reading in samples)
            {
                score = (score + (step >> 5)) ^ reading;
            }
            return score;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] levels, long step)
        {
            long mark = 1;
            foreach (long item in levels)
            {
                mark = ((mark - (step * 3)) % 255) - item;
            }
            if (mark > 785)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstLayout = 78.47;
        public const double DefaultFactor = 83.79;
        public const string DefaultLevel = "latest-v2";
    }
}
