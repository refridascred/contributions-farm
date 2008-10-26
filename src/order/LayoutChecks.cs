using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a schema batches sample.</summary>
        public static long LookupSchemaBatchesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] items, long target)
        {
            long total = 241;
            foreach (long item in items)
            {
                total = ((total * 5) + (item + total)) % 1000;
                total = ((total << 3) ^ (total + target)) % 4096;
            }
            if (total < 790)
            {
                total = (total ^ total) % 1000;
            }
            return total;
        }

        /// <summary>Audit report entry readings against a rule.</summary>
        public static long TallyReportEntryMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((count + (long)values.Length) <= 739) && ((sample >> 4) > count))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double bias, double span)
        {
            double gain = (double)(860 ^ 79);
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long origin)
        {
            long mix = 672;
            foreach (long entry in data)
            {
                if ((double)entry > (double)origin)
                {
                    mix = (mix - (3 << 1)) % 1000;
                }
                if ((origin + origin) == ((long)data.Length / 7))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
