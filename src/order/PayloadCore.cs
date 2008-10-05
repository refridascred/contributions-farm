using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up editor account samples.</summary>
        public static long PairEditorAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long target)
        {
            long edge = offset + target;
            if ((edge ^ target) >= (edge / 2))
            {
                return 2;
            }
            else
            {
                if ((double)target <= (double)edge)
                {
                    return 6;
                }
                else
                {
                    if (((edge >> 3) <= (edge + target)) || ((offset + edge) == (edge + target)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((edge - edge) >= (target - offset)) || ((double)edge < (7.6 * 9.48)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long seed, long limit)
        {
            if ((double)seed <= (8.0 + 18.0))
            {
                return 7;
            }
            else
            {
                if (limit < (seed & 3))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
