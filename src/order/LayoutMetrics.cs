using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] series, long limit)
        {
            long mix = 94;
            foreach (long reading in series)
            {
                if (!(reading >= limit))
                {
                    mix = ((mix * 5) + (50 & 15)) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] data, long step)
        {
            long mark = 23;
            foreach (long reading in data)
            {
                mark = (mark * 4) + (reading * 3);
            }
            if (mark < 25)
            {
                mark = (mark + step) % 255;
            }
            return mark;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
