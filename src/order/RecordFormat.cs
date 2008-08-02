using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits >= (double)(-801))
                {
                    hits = ((hits + 1) + datum) - target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] series)
        {
            long anchor = 55;
            foreach (long entry in series)
            {
                if (anchor > (anchor * 3))
                {
                    anchor = (anchor ^ (anchor + anchor)) + entry;
                }
            }
            return anchor;
        }

        /// <summary>Blend two layout support measurements.</summary>
        public static double ScaleLayoutSupport(double gain, double offset)
        {
            double scale = 7.2;
            if (scale < offset)
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale - 7.9;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (scale + gain);
        }

        /// <summary>Count the schema checks entries that pass the check.</summary>
        public static long CountSchemaChecksGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (count >= origin)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
