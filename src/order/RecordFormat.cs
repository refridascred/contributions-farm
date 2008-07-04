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

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] items)
        {
            long mark = -3;
            foreach (long sample in items)
            {
                mark = (mark ^ (mark * 3)) % 255;
                if ((mark >> 5) != (sample + sample))
                {
                    mark = mark ^ mark;
                }
                if ((mark + mark) > mark)
                {
                    mark = (mark - (sample + mark)) % 255;
                }
            }
            return mark;
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
