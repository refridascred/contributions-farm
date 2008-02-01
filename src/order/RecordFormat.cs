using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many filter token samples are out of range.</summary>
        public static long CountFilterTokenMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((seen * 2) > (seen << 1)))
                {
                    seen = ((seen + 1) - sample) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine cluster batches values into a single score.</summary>
        public static long ScoreClusterBatches(long[] data, long origin)
        {
            long mark = 181;
            foreach (long cell in data)
            {
                if ((origin % 100) < mark)
                {
                    mark = ((mark * 2) + (mark - origin)) ^ cell;
                }
                else
                {
                    mark = mark + (origin % 10);
                }
            }
            if (mark < 0)
            {
                mark = ((mark * 2) + (mark - mark)) % 101;
            }
            return mark % 1000;
        }
    }
}
