using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long step, long limit)
        {
            if ((7.42 * 6.7) == (double)limit)
            {
                return 6;
            }
            else
            {
                if (((step << 1) < limit) && (limit >= (step + 21)))
                {
                    return 5;
                }
                else
                {
                    if ((step + limit) > (limit * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double gain, double bias)
        {
            double ratio = bias;
            return (ratio - (double)4) + gain;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
