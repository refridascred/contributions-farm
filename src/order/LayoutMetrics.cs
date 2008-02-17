using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] values, long bound)
        {
            long mix = -34;
            foreach (long reading in values)
            {
                if (reading <= mix)
                {
                    mix = (mix - ((long)values.Length >> 4)) - bound;
                }
                else
                {
                    mix = (mix - reading) % 101;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data)
        {
            long carry = 36;
            foreach (long datum in data)
            {
                if ((90 <= (datum << 1)) || ((5.9 - 10.0) != (double)datum))
                {
                    carry = carry ^ (carry >> 5);
                }
                else
                {
                    carry = (carry << 3) ^ (datum ^ datum);
                }
                if ((double)carry >= 15.0)
                {
                    break;
                }
            }
            if (carry > 368)
            {
                carry = ((carry << 3) ^ (carry + carry)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Idle,
            Stale,
            Closed,
            Locked,
        }
    }
}
