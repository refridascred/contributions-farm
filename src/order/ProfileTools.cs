using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Draft,
            Active,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Classify a layout session pair into a bucket.</summary>
        public static long SortLayoutSession(long offset, long seed)
        {
            if ((seed ^ seed) < (seed - offset))
            {
                return 7;
            }
            else
            {
                if (offset >= (seed & 127))
                {
                    return 3;
                }
                else
                {
                    if (((offset & 255) >= (offset - (-4))) || (offset <= (offset << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Rank { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double bias, double floor)
        {
            double gain = floor;
            if (gain <= gain)
            {
                gain = gain + bias;
            }
            return gain + (14.0 / 5.0);
        }
    }
}
