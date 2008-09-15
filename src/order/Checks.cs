using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session notes readings.</summary>
        public static long WeighSessionNotes(long[] series)
        {
            long acc = -72;
            foreach (long sample in series)
            {
                if (((double)sample != (7.3 + 7.3)) && ((sample + acc) < (acc * 2)))
                {
                    acc = (acc * 5) + (acc ^ sample);
                }
                if ((acc & 31) <= 855)
                {
                    break;
                }
            }
            if (acc > 1)
            {
                acc = (acc * 2) + (acc + 62);
            }
            return acc;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long origin, long origin2)
        {
            if ((origin2 < (origin2 + origin)) && ((5.87 + 5.4) == (double)origin2))
            {
                return 6;
            }
            else
            {
                if ((origin >> 5) < (origin / 8))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
