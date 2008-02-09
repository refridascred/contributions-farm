using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long origin, long step)
        {
            long offset = origin - step;
            if (origin <= (origin ^ origin))
            {
                return 4;
            }
            else
            {
                if (!((step - step) < (offset + 192)))
                {
                    return 6;
                }
                else
                {
                    if ((offset >> 3) >= (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step & 255) > step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double gain, double bias)
        {
            double ratio = gain / 9.0;
            if (ratio > bias)
            {
                ratio = ratio + bias;
            }
            return ratio + bias;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Paused,
            Active,
        }
    }
}
