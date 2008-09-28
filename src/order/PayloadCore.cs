using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first contributi payload entry that matches the target.</summary>
        public static long SeekContributiPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long step, long seed)
        {
            if ((seed % 10) > (seed - 409))
            {
                return 2;
            }
            else
            {
                if (((step - step) == (1 * 4)) && ((seed - step) < (seed >> 3)))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed < (3.0 + 6.99))
                    {
                        return 5;
                    }
                    else
                    {
                        if (4.0 > (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
