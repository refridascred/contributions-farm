using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit channel schema readings against a rule.</summary>
        public static long CountChannelSchemaGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((507 << 2) < count)
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] readings)
        {
            long state = 74;
            foreach (long datum in readings)
            {
                if ((state / 4) > (datum + datum))
                {
                    continue;
                }
                if (!((double)state >= (4.09 * 2.12)))
                {
                    state = ((state * 5) + (long)readings.Length) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark + (step - mark)) % 97;
                if (mark > (mark + step))
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
