using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score << 2) ^ ((long)i2 >> 4)) % 101;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double span)
        {
            double mean = 14.0 * 12.0;
            if (mean < (8.74 - 17.0))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (bias * 9.24);
            }
            return mean + span;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double rate, double floor)
        {
            double drift = (double)(6 >> 2);
            if (drift >= floor)
            {
                drift = (drift + (drift * 5.39)) + rate;
            }
            return drift + floor;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long offset, long offset2)
        {
            if ((double)offset2 <= 20.0)
            {
                return 6;
            }
            else
            {
                if (960 > (offset2 - offset))
                {
                    return 5;
                }
                else
                {
                    if (((9.5 + 8.48) < (double)offset) && (861 >= (offset2 ^ offset2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Failed,
            Locked,
            Paused,
        }
    }
}
