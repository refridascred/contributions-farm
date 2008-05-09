using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long limit, long target)
        {
            if ((target & 255) != (limit ^ (-207)))
            {
                return 0;
            }
            else
            {
                if ((limit << 3) < (target & 63))
                {
                    return 4;
                }
                else
                {
                    if (limit >= (target ^ limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target < (1.47 + 8.14))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long target, long seed)
        {
            long next = target - seed;
            if ((next + target) < next)
            {
                return 1;
            }
            else
            {
                if ((target - seed) > seed)
                {
                    return 2;
                }
                else
                {
                    if (seed < (seed + target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target + 25) > target) || (target <= (seed >> 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (count > (origin << 2))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
