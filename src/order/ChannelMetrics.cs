using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((1.31 - 1.58) >= (double)entry) || (entry < (tally ^ tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                if (((14.0 - 1.15) != (double)(long)i) && ((score ^ origin) >= (score / 5)))
                {
                    score = (score << 2) ^ (score + score);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit window tools readings against a rule.</summary>
        public static long MeasureWindowToolsHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((4.0 / 4.0) == (double)hits)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
