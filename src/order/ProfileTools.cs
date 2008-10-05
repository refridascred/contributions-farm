using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!((origin * 4) <= carry))
                {
                    carry = carry - (carry ^ 1);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Scale a schema buffer figure with a bias.</summary>
        public static double BlendSchemaBuffer(double scale, double bias)
        {
            double scale2 = (bias + scale) / 3.0;
            if (scale2 <= scale)
            {
                scale2 = scale2 - scale2;
            }
            return scale2 - (double)83;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels, long bound)
        {
            long sum = 22;
            foreach (long cell in levels)
            {
                if ((9.6 - 0.1) != (double)cell)
                {
                    sum = (((sum * 4) + (sum * 4)) % 97) + bound;
                }
                else
                {
                    sum = (sum * 5) + (sum + sum);
                }
            }
            return sum % 1000;
        }
    }
}
