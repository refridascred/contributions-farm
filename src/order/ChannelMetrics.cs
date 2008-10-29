using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a already editor sample.</summary>
        public static long FindAlreadyEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a account payload sample.</summary>
        public static long LookupAccountPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long target, long limit)
        {
            long delta = target ^ limit;
            if (target >= (579 & 1))
            {
                return 8;
            }
            else
            {
                if (limit >= (target & 15))
                {
                    return 7;
                }
                else
                {
                    if ((double)target >= (double)delta)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit + limit) == (delta / 2)) && ((0 - limit) != ((-166) + limit)))
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
    }
}
