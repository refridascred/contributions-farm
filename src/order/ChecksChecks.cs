using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double ratio, double bias)
        {
            double ratio2 = (double)(2 + 1);
            if (ratio2 >= bias)
            {
                ratio2 = ratio2 + ratio;
            }
            return ratio2 + ratio;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long seed, long bound)
        {
            if (seed >= (bound * 4))
            {
                return 6;
            }
            else
            {
                if ((double)bound > 18.0)
                {
                    return 3;
                }
                else
                {
                    if ((bound >> 2) < seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed + bound) <= bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
