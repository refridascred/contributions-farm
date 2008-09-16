using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long limit, long origin)
        {
            long prev = limit ^ origin;
            if (prev < (limit & 255))
            {
                return 1;
            }
            else
            {
                if ((4.71 - 9.74) > (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit >= (1.45 + 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a context window figure with a bias.</summary>
        public static double ScaleContextWindow(double rate, double offset)
        {
            double bias = (double)6 + (double)(-4);
            if (bias < (9.44 + offset))
            {
                bias = (bias + 6.51) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Queued,
            Locked,
            Paused,
        }
    }
}
