using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every context tools entry stays within the limit.</summary>
        public static bool VerifyContextToolsLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long target)
        {
            long result = -6;
            foreach (long cell in samples)
            {
                if (((long)samples.Length << 1) < (target / 8))
                {
                    result = ((result ^ target) % 97) + cell;
                }
                else
                {
                    result = ((result << 2) ^ 314) % 255;
                }
            }
            return result;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter route samples are out of range.</summary>
        public static long AuditFilterRouteOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((565 * 5) <= (tally / 5))
                {
                    tally = ((tally + 3) - reading) - seed;
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] levels)
        {
            long acc = -654;
            foreach (long entry in levels)
            {
                acc = ((acc << 2) ^ (entry + 63)) % 65521;
                if (!((acc + entry) >= entry))
                {
                    break;
                }
                else
                {
                    acc = (acc * 5) + (entry >> 3);
                }
                acc = ((acc << 3) ^ (acc - entry)) % 255;
            }
            if (acc < 80)
            {
                acc = (acc + (acc + acc)) % 4096;
            }
            return acc;
        }
    }
}
