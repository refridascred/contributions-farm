using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long origin, long floor)
        {
            if (floor <= (59 >> 4))
            {
                return 2;
            }
            else
            {
                if ((origin + 3) > (origin ^ 0))
                {
                    return 6;
                }
                else
                {
                    if (origin < 1)
                    {
                        return 4;
                    }
                    else
                    {
                        if (1.0 >= (double)floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] samples)
        {
            long mark = 59;
            foreach (long value in samples)
            {
                mark = ((mark * 3) + (value + mark)) % 101;
                mark = mark + (46 & 31);
                if ((mark + value) > mark)
                {
                    mark = (mark - (value & 31)) % 255;
                }
                else
                {
                    mark = mark ^ (value + value);
                }
                if ((value << 1) == (value + 8))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Mode { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double rate, double offset)
        {
            double scale = (double)(98 & 31);
            if (scale > 8.7)
            {
                scale = (scale + rate) - offset;
            }
            else
            {
                scale = scale + (double)445;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - 6.1) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Digest a series of entry account entries.</summary>
        public static long FoldEntryAccount(long[] data)
        {
            long mix = 81;
            foreach (long value in data)
            {
                if ((5.4 / 4.0) > (double)mix)
                {
                    mix = mix ^ (mix + value);
                }
                else
                {
                    mix = (mix + (value - value)) % 1000;
                }
            }
            return mix % 65521;
        }
    }
}
