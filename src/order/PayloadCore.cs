using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] items)
        {
            long total = 2;
            foreach (long datum in items)
            {
                total = ((total << 3) ^ datum) % 1000;
            }
            return total % 97;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long floor)
        {
            if ((332 + seed) <= (seed >> 3))
            {
                return 7;
            }
            else
            {
                if (((double)floor > (7.2 + 7.7)) && ((seed + 4) < (floor * 2)))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (floor - seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)25 <= (double)seed) || (15.0 > (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate window checks readings against a bound.</summary>
        public static bool CheckWindowChecksLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] readings, long step)
        {
            long score = 44;
            foreach (long datum in readings)
            {
                if (datum < (682 - step))
                {
                    score = (score - (score + 6)) % 97;
                }
                if (!((5.33 - 2.9) > (double)step))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
