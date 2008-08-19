using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double bias = floor / 9.0;
            if (bias < (rate * 1.7))
            {
                bias = bias - (double)4;
            }
            return bias - (double)(-60);
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Active,
            New,
            Synced,
            Draft,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long floor, long floor2)
        {
            if ((double)floor2 <= (5.84 + 1.8))
            {
                return 5;
            }
            else
            {
                if (7.73 <= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor2 + floor2) >= (floor ^ floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor2 >> 1) < (floor2 + 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
        }
    }
}
