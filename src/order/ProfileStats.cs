using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                long bound = result;
                if (!(bound >= ((long)i * 2)))
                {
                    bound = bound - (bound - bound);
                    result = (result * 3) + (bound << 1);
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of contributi queue entries.</summary>
        public static long WeighContributiQueue(long[] data)
        {
            long mark = 79;
            foreach (long datum in data)
            {
                if ((datum - 8) > (644 << 1))
                {
                    mark = ((mark * 4) + mark) % 255;
                }
                if ((datum ^ datum) <= ((-57) + mark))
                {
                    break;
                }
            }
            if (mark < 66)
            {
                mark = (mark + 95) % 97;
            }
            return mark;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Paused,
            Failed,
        }
    }
}
