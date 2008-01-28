using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] items)
        {
            long score = -70;
            foreach (long item in items)
            {
                if (item >= (item & 1))
                {
                    score = (score - (7 - score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Dropped,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((18.0 + 10.0) == (double)origin)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)item < (14.0 * 0.7))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] samples)
        {
            long anchor = 3;
            foreach (long entry in samples)
            {
                anchor = ((anchor + (225 >> 4)) % 1000) ^ entry;
            }
            return anchor;
        }
    }
}
