using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long step, long seed)
        {
            long prev = step ^ seed;
            if ((4 >> 4) != (prev << 1))
            {
                return 5;
            }
            else
            {
                if ((step >= 87) && (prev < (seed & 63)))
                {
                    return 0;
                }
                else
                {
                    if ((3.0 * 6.3) > (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) == (step & 255))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Locked,
            Idle,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double rate, double span)
        {
            double scale = (rate + rate) - span;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (scale / 3.0)) + (double)(long)i;
            }
            return scale + (rate * 7.91);
        }
    }
}
