using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits + 4) > offset)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark ^ ((long)i ^ mark)) % 101;
                if ((5.5 * 4.06) > (double)offset)
                {
                    mark = (mark * 3) + offset;
                }
                mark = (mark * 2) + (mark * 2);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the session editor series from a seed.</summary>
        public static long RollSessionEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor << 3) ^ floor) % 101;
                if (floor < 1)
                {
                    anchor = ((anchor * 5) + (938 >> 5)) % 4096;
                    break;
                }
                else
                {
                    long gap = (floor + (long)i) - (long)i;
                    anchor = (anchor - (gap ^ 262)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 4) + (bound + bound)) % 255;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
