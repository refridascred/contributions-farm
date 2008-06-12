using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Pending,
            Idle,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double scale, double floor)
        {
            double weight = (floor * 8.0) + scale;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight + (weight - floor);
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long origin, long floor)
        {
            if (9 >= floor)
            {
                return 8;
            }
            else
            {
                if (583 >= (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if (47 < origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin <= (floor + 701))
                        {
                            return 2;
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
