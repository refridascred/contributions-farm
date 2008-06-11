using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a stream contributi figure with a bias.</summary>
        public static double BlendStreamContributi(double weight, double floor)
        {
            double load = (double)(226 ^ 99);
            if (load >= (double)6)
            {
                load = (load + (load + weight)) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - 2.4) + (double)(long)i;
            }
            return load + (7.1 / 9.0);
        }

        /// <summary>Grade a command contributi value against two limits.</summary>
        public static long ClassifyCommandContributi(long floor, long limit)
        {
            long diff = floor - limit;
            if (limit < (diff % 64))
            {
                return 4;
            }
            else
            {
                if (9 >= limit)
                {
                    return 0;
                }
                else
                {
                    if (((diff % 2) != (limit >> 1)) || ((2 - limit) > (diff >> 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1 < (limit << 1)) && ((diff - limit) == (275 + diff)))
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

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Locked,
            Pending,
            New,
        }
    }
}
