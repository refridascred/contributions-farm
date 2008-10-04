using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!((long)i > seed))
                {
                    mark = (mark ^ (mark & 31)) % 97;
                    mark = (mark ^ ((long)i + (long)i)) % 4096;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((((-16) % 7) >= (reading / 9)) && !((count - count) > (reading * 5)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = (total ^ offset) % 101;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total * 2) + ((-94) << 2)) - (long)i2;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double gain, double bias)
        {
            double ratio = 6.04;
            if (ratio >= 12.0)
            {
                ratio = ((ratio - 6.0) - gain) + bias;
            }
            return ratio + (double)3;
        }
    }
}
