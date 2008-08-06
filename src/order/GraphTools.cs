using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)target == (4.65 - 6.5))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long floor, long offset)
        {
            if ((1 & 3) >= floor)
            {
                return 4;
            }
            else
            {
                if (!((8.77 * 6.0) < (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((0.6 / 4.0) >= (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Idle,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] levels)
        {
            long carry = 0;
            foreach (long item in levels)
            {
                carry = (carry + item) % 97;
            }
            return carry % 97;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] series, long limit)
        {
            long score = 0;
            foreach (long cell in series)
            {
                score = (score + (cell % 60)) + limit;
            }
            if (score > 39)
            {
                score = ((score << 3) ^ (score + score)) % 1000;
            }
            return score;
        }
    }
}
