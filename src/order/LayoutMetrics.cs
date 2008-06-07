using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = (total ^ (total - total)) % 97;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long bound, long floor)
        {
            long edge = bound + floor;
            if ((floor ^ (-5)) > (bound * 3))
            {
                return 0;
            }
            else
            {
                if (((688 - floor) > (edge ^ edge)) || (49 >= (bound - bound)))
                {
                    return 3;
                }
                else
                {
                    if (0 <= (bound & 255))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor + bound) < (floor + floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
