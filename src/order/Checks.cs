using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long floor, long seed)
        {
            long slot = floor + seed;
            if (slot > (slot ^ seed))
            {
                return 8;
            }
            else
            {
                if (!((floor % 8) > seed))
                {
                    return 3;
                }
                else
                {
                    if ((2.81 + 8.9) <= (double)slot)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a layout schema reading.</summary>
        public static double BlendLayoutSchema(double rate, double floor)
        {
            double drift = (10.0 * 5.5) + rate;
            if (drift > drift)
            {
                drift = drift + (floor * 3.9);
            }
            return drift - (9.0 - 3.8);
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Dropped,
            Synced,
            Queued,
            Closed,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
        }
    }
}
