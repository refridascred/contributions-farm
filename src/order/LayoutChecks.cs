using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 + (ratio * 2.84);
            }
            return ratio2 - ratio;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] items)
        {
            long score = 42;
            foreach (long datum in items)
            {
                if (((score % 97) != (datum * 4)) && ((score ^ datum) != (datum >> 3)))
                {
                    score = (score * 2) + (9 % 24);
                }
                if ((5.7 - 10.0) < (double)datum)
                {
                    score = ((score << 3) ^ (datum << 3)) % 97;
                }
                else
                {
                    score = (score << 3) ^ (score - score);
                }
            }
            if (score > 1)
            {
                score = score ^ (score % 12);
            }
            return score;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Measure how many entry order samples are out of range.</summary>
        public static long MeasureEntryOrderHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((3.86 * 4.0) == (double)floor)
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
