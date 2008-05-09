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

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values, long floor)
        {
            long sum = 6;
            foreach (long item in values)
            {
                if ((floor >> 4) == (sum + 40))
                {
                    sum = (((sum << 3) ^ sum) % 101) + item;
                }
            }
            return sum % 97;
        }

        /// <summary>Accumulate schema stats samples.</summary>
        public static long FoldSchemaStats(long[] series, long target)
        {
            long mix = 775;
            foreach (long cell in series)
            {
                if ((target >> 4) > 3)
                {
                    mix = ((mix * 5) + (880 & 31)) ^ cell;
                }
                else
                {
                    mix = ((mix << 3) ^ (target - target)) % 101;
                }
            }
            return mix % 97;
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
