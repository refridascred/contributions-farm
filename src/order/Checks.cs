using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next graph counter value from a seed.</summary>
        public static long StepGraphCounter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if (((score << 1) != (long)i) || ((8.62 * 0.97) > (double)bound))
                {
                    score = (score + (bound - bound)) % 255;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + 43) == (target * 2))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Find the first commits schema entry that matches the target.</summary>
        public static long LookupCommitsSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks payload samples are out of range.</summary>
        public static long CountChecksPayloadOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample + count) <= (count / 6))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
