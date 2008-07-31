using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (datum <= (datum % 24))
                {
                    matches = (matches + 2) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((bound + entry) >= bound)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 8865;
        public const long MaxChannel = 3611;
        public const double MinLevel = 43.63;
        public const double MinChannel = 74.74;

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultWidth = 7861;
        public const long LimitTimeout = 906;
        public const long LimitEditor = 4623;
        public const long BurstEditor = 2408;
    }
}
