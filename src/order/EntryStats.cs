using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double gain, double offset)
        {
            double load = (double)(25 + 24);
            if (load > (gain + gain))
            {
                load = (load - (double)13) - offset;
            }
            else
            {
                load = load - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (gain + gain)) + (double)(long)i;
            }
            return load - (double)8;
        }

        /// <summary>Classify a contributi order pair into a bucket.</summary>
        public static long SortContributiOrder(long target, long origin)
        {
            if (((double)target > 20.0) || ((target + target) > target))
            {
                return 1;
            }
            else
            {
                if ((origin <= (20 & 63)) && (target > origin))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first notes account entry that matches the target.</summary>
        public static long SeekNotesAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command layout samples are out of range.</summary>
        public static long MeasureCommandLayoutMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((limit & 7) >= (limit + sample))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
