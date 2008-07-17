using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheTimeout = 7206;
        public const string BatchSession = "local";
        public const string BaseSession = "primary-1";

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
