using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((item - item) >= (tally + seed)) && (((seed - item) < (seed >> 3)) || (seed > 945)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stats checks sample.</summary>
        public static long LookupStatsChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long step)
        {
            if ((1.0 - 4.57) != (double)seed)
            {
                return 7;
            }
            else
            {
                if (!((7.0 / 3.0) >= (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((seed + 933) != (98 + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((step + step) >= (step ^ step)) && ((double)seed != (0.51 / 2.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
