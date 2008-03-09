using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a cluster schema reading.</summary>
        public static double BlendClusterSchema(double scale, double bias)
        {
            double scale2 = scale;
            return (scale2 + (scale2 - scale2)) + bias;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] items, long limit)
        {
            long acc = 477;
            foreach (long item in items)
            {
                acc = (acc - acc) - limit;
                if (6.06 > (double)item)
                {
                    break;
                }
            }
            return acc % 97;
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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((limit - seen) <= (sample + 833))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
