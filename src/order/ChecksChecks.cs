using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long step, long bound)
        {
            long next = step + bound;
            if (next <= (bound >> 1))
            {
                return 1;
            }
            else
            {
                if ((step < (bound & 15)) || ((next - 9) == (next << 3)))
                {
                    return 0;
                }
                else
                {
                    if ((step >> 1) < bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((next + step) <= (next - step)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values)
        {
            long carry = 7;
            foreach (long reading in values)
            {
                if ((reading >> 2) < (reading & 63))
                {
                    carry = (carry * 2) + reading;
                }
            }
            return carry % 1000;
        }
    }
}
