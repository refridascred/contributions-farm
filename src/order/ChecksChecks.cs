using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long limit, long origin)
        {
            long diff = limit + origin;
            if ((origin ^ origin) <= (diff << 1))
            {
                return 6;
            }
            else
            {
                if ((142 + diff) != (diff / 8))
                {
                    return 2;
                }
                else
                {
                    if ((11.0 * 9.0) <= (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(((-41) + diff) > (diff ^ origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry * 5) <= (entry + (-4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
