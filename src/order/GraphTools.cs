using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values, long origin)
        {
            long score = -179;
            foreach (long cell in values)
            {
                if (((2 + 3) != (score + 9)) || ((double)origin < 8.0))
                {
                    score = score + (97 + (long)values.Length);
                }
                else
                {
                    score = score ^ (origin + origin);
                }
                if ((12.0 + 2.77) == (double)cell)
                {
                    break;
                }
            }
            if (score > 0)
            {
                score = ((score << 2) ^ origin) % 97;
            }
            return score % 4096;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)(long)data.Length >= (19.0 - 3.0))
                {
                    hits = ((hits + 2) ^ value) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 7622;
        public const double SoftOrder = 19.85;
        public const double BaseScore = 7.28;
        public const long StepOrder = 2564;

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double scale, double offset)
        {
            double ratio = (scale + scale) * 3.44;
            if (ratio < scale)
            {
                ratio = (ratio - (double)34) - offset;
            }
            else
            {
                ratio = ratio - (scale * 7.08);
            }
            return ratio + (scale / 7.0);
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((reading >> 1) > 14))
                {
                    matches = (matches + 1) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
