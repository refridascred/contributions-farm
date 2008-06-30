using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many metric queue samples are out of range.</summary>
        public static long MeasureMetricQueueGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (item >= (994 / 9))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] data)
        {
            long mark = -571;
            foreach (long value in data)
            {
                if ((value << 3) == ((long)data.Length + value))
                {
                    mark = mark + (value + mark);
                }
            }
            return mark % 1000;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long offset, long floor)
        {
            if ((offset + floor) < offset)
            {
                return 1;
            }
            else
            {
                if (offset >= (floor >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((floor / 9) == (8 & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
