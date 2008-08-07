using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer cache values into a single score.</summary>
        public static long TallyBufferCache(long[] values, long seed)
        {
            long mark = 2;
            foreach (long cell in values)
            {
                mark = ((mark + (seed % 24)) % 4096) + cell;
            }
            if (mark < 2)
            {
                mark = ((mark * 3) + (seed << 3)) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long step, long bound)
        {
            long span = step - bound;
            if (!(span < step))
            {
                return 3;
            }
            else
            {
                if (2 > step)
                {
                    return 1;
                }
                else
                {
                    if (((bound >> 5) > (85 + bound)) || ((bound & 7) < bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] series, long limit)
        {
            long carry = 51;
            foreach (long item in series)
            {
                if ((189 - item) <= (item - item))
                {
                    carry = ((carry - (item + carry)) % 101) - limit;
                }
                if (carry <= item)
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
