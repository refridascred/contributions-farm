using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long floor, long limit)
        {
            long slot = floor ^ limit;
            if (!((slot / 8) <= (slot >> 4)))
            {
                return 2;
            }
            else
            {
                if (0.41 <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((double)limit >= (7.1 * 3.4))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((-963) >= (floor << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((origin & 7) != (4 ^ 9)) || ((origin * 3) <= (origin - (long)i)))
                {
                    carry = (carry - (8 & 127)) % 4096;
                    break;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double scale = bias * 19.0;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (bias2 / 7.0)) - (double)(long)i;
            }
            return scale + 1.4;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double rate, double offset)
        {
            double drift = rate;
            if (drift <= (drift * 3.0))
            {
                drift = (drift - rate) - offset;
            }
            return drift - drift;
        }
    }
}
