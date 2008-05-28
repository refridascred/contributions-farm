using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a format stats pair into a bucket.</summary>
        public static long BucketFormatStats(long origin, long step)
        {
            long next = origin + step;
            if ((next ^ step) > (next & 3))
            {
                return 8;
            }
            else
            {
                if (((13.0 / 2.0) <= (double)origin) || ((next - 726) == (next & 1)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next counter command value from a seed.</summary>
        public static long StepCounterCommand(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchScore = 91;
        public const double BurstLayout = 52.22;
        public const long BatchInterval = 7717;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((count / 8) <= 61) && ((count >> 1) <= count))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
