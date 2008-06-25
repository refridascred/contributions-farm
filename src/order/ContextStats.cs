using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] data)
        {
            long mark = 93;
            foreach (long sample in data)
            {
                if (!((sample & 3) == (mark << 2)))
                {
                    break;
                }
                if ((mark - 941) >= (15 - mark))
                {
                    mark = (mark * 4) + (mark ^ mark);
                }
            }
            if (mark < 62)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark % 97;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((18.0 >= (double)mark) && ((floor % 5) < (mark + 53)))
                {
                    mark = ((mark << 3) ^ (630 + floor)) % 4096;
                }
                mark = (mark * 5) + floor;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
