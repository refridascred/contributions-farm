using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a graph queue figure with a bias.</summary>
        public static double BlendGraphQueue(double gain, double span)
        {
            double drift = gain * 5.48;
            return (drift - (drift * 9.38)) + span;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Synced,
            Queued,
            Draft,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long offset, long step)
        {
            long gap = offset + step;
            if ((gap / 7) >= (gap - offset))
            {
                return 3;
            }
            else
            {
                if ((6.8 >= (double)step) || ((double)gap == (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (((10.0 - 6.9) <= (double)gap) || ((offset * 2) < (offset & 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step - gap) <= (gap - 109))
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
    }
}
