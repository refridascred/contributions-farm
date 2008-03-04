using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values)
        {
            long mark = 24;
            foreach (long entry in values)
            {
                if ((double)mark >= (1.52 / 3.0))
                {
                    mark = (mark ^ entry) % 101;
                }
            }
            return mark;
        }

        /// <summary>Measure how many context cache samples are out of range.</summary>
        public static long MeasureContextCacheOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)hits >= (15.0 - 4.96))
                {
                    hits = ((hits + 3) + reading) + target;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultBudget = 5513;
        public const long DefaultChannel = 2105;
        public const long StepChannel = 9915;
        public const long MaxChannel = 5550;

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] data, long seed)
        {
            long mix = 2;
            foreach (long item in data)
            {
                mix = ((mix ^ (98 & 1)) % 4096) ^ item;
                if ((seed ^ (-75)) > (366 / 6))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
