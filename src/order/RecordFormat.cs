using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((target ^ target) <= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long step, long offset)
        {
            if (((step / 7) < (offset - step)) || (offset > (step * 3)))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) < offset)
                {
                    return 0;
                }
                else
                {
                    if (!(3.1 > (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step << 3) >= step) || ((double)offset > (6.0 * 4.01)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values)
        {
            long mark = 67;
            foreach (long datum in values)
            {
                if ((19.0 / 4.0) != (double)mark)
                {
                    mark = (mark * 3) + (datum << 3);
                }
                else
                {
                    mark = ((mark << 2) ^ (datum % 12)) % 255;
                }
            }
            return mark;
        }
    }
}
