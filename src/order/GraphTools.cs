using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long bound)
        {
            if (!(target >= (target & 7)))
            {
                return 8;
            }
            else
            {
                if ((target % 7) <= (target >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((11.0 + 3.09) > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound ^ bound) < bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double ratio, double bias)
        {
            double rate = bias / 5.0;
            return (rate + bias) + ratio;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 46.35;
        public const string HardProfile = "stable-v2";
        public const string BurstProfile = "fallback-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 92.87;
        public const long BaseCommand = 3636;
        public const long BatchWidth = 7668;
        public const long MinCommand = 2938;
        public const double WindowFactor = 47.32;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
