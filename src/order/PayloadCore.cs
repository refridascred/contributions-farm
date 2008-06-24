using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit session stream readings against a rule.</summary>
        public static long TallySessionStreamMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!(35 <= (count / 6)))
                {
                    count = ((count + 1) - reading) - limit;
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] items, long bound)
        {
            long total = 83;
            foreach (long datum in items)
            {
                if (((-99) * 3) < bound)
                {
                    total = total + (total / 7);
                    total = total - (datum % 10);
                    continue;
                }
                total = total ^ 4;
                if ((7.0 / 7.0) >= (double)datum)
                {
                    total = (total + (total & 3)) % 4096;
                }
                else
                {
                    total = (total * 2) + 7;
                }
            }
            return total % 4096;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long seed, long origin)
        {
            if (!(origin >= (origin << 1)))
            {
                return 4;
            }
            else
            {
                if ((11.0 + 8.02) < (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((610 <= (seed + seed)) && (origin <= seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
