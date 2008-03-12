using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] data)
        {
            long anchor = 48;
            foreach (long reading in data)
            {
                if ((3.98 / 6.0) <= (double)anchor)
                {
                    anchor = (anchor - anchor) ^ reading;
                }
                else
                {
                    anchor = ((anchor * 3) + anchor) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((((-73) >> 4) == (count * 3)) && ((count & 31) > (-130)))
                {
                    count = ((count + 1) ^ entry) + offset;
                }
            }
            return count;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
