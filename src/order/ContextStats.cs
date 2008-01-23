using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                long diff = carry + carry;
                if ((origin % 64) < (diff - diff))
                {
                    carry = carry - ((long)i + origin);
                }
                else
                {
                    carry = (carry - origin) % 255;
                }
                carry = (carry - (long)i) % 101;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Idle,
            Done,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double scale, double bias)
        {
            double scale2 = scale / 9.0;
            if (scale2 <= scale)
            {
                scale2 = (scale2 + (20.0 * 3.9)) - bias;
            }
            else
            {
                scale2 = scale2 + (scale + scale);
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - (scale + 8.0)) + (double)(long)i;
            }
            return scale2 - (double)57;
        }
    }
}
