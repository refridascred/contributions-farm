using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit graph buffer readings against a rule.</summary>
        public static long MeasureGraphBufferOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((7.0 + 8.8) <= (double)entry)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (618 >= matches)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Measure how many account buffer samples are out of range.</summary>
        public static long MeasureAccountBufferGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((((2.48 / 3.0) < (double)seen) && (entry >= seen)) && (seen > (entry << 3)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] data, long offset)
        {
            long score = 923;
            foreach (long datum in data)
            {
                if ((offset & 31) == (datum - (long)data.Length))
                {
                    score = score - offset;
                }
                score = score + (240 & 1);
            }
            return score;
        }
    }
}
