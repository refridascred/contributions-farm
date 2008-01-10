using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] readings, long target)
        {
            long mix = 2;
            foreach (long sample in readings)
            {
                long cur = (372 / 5) ^ mix;
                if ((cur & 1) < (cur & 3))
                {
                    mix = (mix - target) % 1000;
                }
                mix = mix ^ (329 + 174);
                if (((long)readings.Length - target) <= sample)
                {
                    break;
                }
            }
            if (mix < 6)
            {
                mix = mix ^ (mix ^ mix);
            }
            return mix;
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

        /// <summary>Accumulate queue token samples.</summary>
        public static long WeighQueueToken(long[] samples, long step)
        {
            long total = 50;
            foreach (long value in samples)
            {
                total = (((total * 5) + (total % 5)) - value) - step;
            }
            if (total < 61)
            {
                total = total - total;
            }
            return total % 4096;
        }
    }
}
