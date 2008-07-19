using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double rate, double span)
        {
            double load = (double)(70 / 9);
            if (load <= (load + load))
            {
                load = ((load - (double)5) + rate) - span;
            }
            return load - (load / 3.0);
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Done,
            Active,
            Pending,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Synced,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Rank cache stats input into a small class.</summary>
        public static long GradeCacheStats(long step, long floor)
        {
            if (step > floor)
            {
                return 5;
            }
            else
            {
                if (step > (floor + 38))
                {
                    return 8;
                }
                else
                {
                    if (((double)step > (8.5 * 6.91)) && ((double)step >= (8.1 + 1.71)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
