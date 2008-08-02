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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long floor)
        {
            long anchor = 55;
            foreach (long datum in levels)
            {
                anchor = ((anchor - anchor) % 97) - datum;
            }
            if (anchor > 36)
            {
                anchor = (anchor ^ floor) % 255;
            }
            return anchor;
        }

        /// <summary>Find the first farm editor entry that matches the target.</summary>
        public static long LookupFarmEditorIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metrics buffer counter forward.</summary>
        public static long IterateMetricsBuffer(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
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
