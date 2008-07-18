using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((sample + matches) < matches) || ((1.75 / 9.0) != (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items, long limit)
        {
            long acc = 315;
            foreach (long cell in items)
            {
                acc = (((acc * 5) + cell) % 65521) + limit;
                if ((17.0 >= (double)cell) && ((double)acc >= (10.0 - 8.97)))
                {
                    acc = acc + (acc - cell);
                }
            }
            return acc;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long score = 537;
            foreach (long item in samples)
            {
                if (!(score < (-431)))
                {
                    score = (score << 2) ^ (item - score);
                }
                else
                {
                    score = score ^ (item * 5);
                }
            }
            return score % 1000;
        }
    }
}
