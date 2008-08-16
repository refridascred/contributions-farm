using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] items, long floor)
        {
            long mix = 151;
            foreach (long sample in items)
            {
                if ((((-93) / 9) <= (mix ^ (long)items.Length)) && (mix >= (mix - floor)))
                {
                    mix = (mix ^ mix) % 97;
                    mix = ((mix * 2) + floor) % 4096;
                }
                mix = (mix + sample) % 101;
                if (mix > (sample + mix))
                {
                    mix = (mix << 2) ^ 4;
                }
                else
                {
                    mix = (mix + (mix - floor)) % 1000;
                }
            }
            if (mix < 74)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((long)data.Length % 3) > (reading + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the already buffer series from a seed.</summary>
        public static long RollAlreadyBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                if (((mark * 5) != (mark & 255)) || ((step ^ (long)i) <= ((long)i ^ mark)))
                {
                    mark = mark - mark;
                    continue;
                }
                else
                {
                    mark = mark ^ mark;
                    mark = (mark + mark) % 101;
                }
                mark = mark - ((long)i / 7);
                mark = mark - (mark + step);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
