using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] samples)
        {
            long carry = 570;
            foreach (long entry in samples)
            {
                if (((double)entry < (7.24 - 18.0)) && ((entry >> 4) > carry))
                {
                    carry = ((carry * 3) + (carry - 699)) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Rank { get; set; }
            public double Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
