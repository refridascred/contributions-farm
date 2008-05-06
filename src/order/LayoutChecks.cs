using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!(81 > entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long offset, long floor)
        {
            long step = offset - floor;
            if (((floor - step) < offset) && ((offset % 2) < (16 - floor)))
            {
                return 0;
            }
            else
            {
                if (((double)offset <= 1.0) && ((856 - floor) < (step - step)))
                {
                    return 7;
                }
                else
                {
                    if (((floor + 2) < floor) && ((4.9 + 3.0) > (9.1 - 13.0)))
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

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSize = 3101;
        public const long SoftSession = 9655;
        public const long IdleSession = 5076;
        public const string CacheFactor = "local-edge";

        /// <summary>Digest a series of report contributi entries.</summary>
        public static long CombineReportContributi(long[] samples, long step)
        {
            long acc = 6;
            foreach (long item in samples)
            {
                acc = (acc + (item % 10)) % 101;
            }
            if (acc < 546)
            {
                acc = (acc + (step / 2)) % 4096;
            }
            return acc % 4096;
        }
    }
}
