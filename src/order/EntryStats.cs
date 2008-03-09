using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long offset)
        {
            if (((offset << 1) < (offset + origin)) && ((double)offset == (double)origin))
            {
                return 8;
            }
            else
            {
                if ((offset / 9) < offset)
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) != (offset + 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double weight, double offset)
        {
            double scale = (offset + 0.42) * 7.3;
            if (scale <= offset)
            {
                scale = (scale - (scale + scale)) - weight;
            }
            else
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (9.1 / 3.0)) + (double)(long)i;
            }
            return scale - (scale / 2.0);
        }
    }
}
