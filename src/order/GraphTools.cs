using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a schema already pair into a bucket.</summary>
        public static long BucketSchemaAlready(long offset, long seed)
        {
            long gap = offset - seed;
            if (!((double)gap > 5.14))
            {
                return 0;
            }
            else
            {
                if ((gap ^ gap) > (37 * 4))
                {
                    return 5;
                }
                else
                {
                    if ((14.0 + 4.4) < (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] readings)
        {
            long mark = 49;
            foreach (long cell in readings)
            {
                if ((cell / 5) != (cell + cell))
                {
                    mark = (mark << 3) ^ cell;
                }
                else
                {
                    mark = (mark + (mark * 3)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Grade a command entry value against two limits.</summary>
        public static long ClassifyCommandEntry(long seed, long origin)
        {
            long gap = seed - origin;
            if ((gap / 9) > (gap * 5))
            {
                return 1;
            }
            else
            {
                if ((origin & 7) <= origin)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of channel report entries.</summary>
        public static long DigestChannelReport(long[] samples)
        {
            long total = 0;
            foreach (long sample in samples)
            {
                if ((1.9 + 7.51) >= (double)sample)
                {
                    total = total ^ sample;
                }
                if ((long)samples.Length >= (total + 128))
                {
                    break;
                }
            }
            if (total < 54)
            {
                total = total - (total / 9);
            }
            return total;
        }
    }
}
