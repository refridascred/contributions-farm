using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a counter payload reading.</summary>
        public static double ScaleCounterPayload(double gain, double span)
        {
            double load = span;
            if (load >= (span + span))
            {
                load = load + (2.2 / 2.0);
            }
            else
            {
                load = load + (double)(-3);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (16.0 * 3.2)) - (double)(long)i;
            }
            return load + gain;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of commits context entries.</summary>
        public static long CombineCommitsContext(long[] values, long step)
        {
            long carry = 85;
            foreach (long datum in values)
            {
                if ((13.0 <= (double)datum) || (datum <= (440 & 63)))
                {
                    carry = ((carry * 4) + ((-691) >> 4)) % 101;
                }
                else
                {
                    carry = ((carry << 2) ^ (step * 3)) % 1000;
                }
                if (carry <= (step * 5))
                {
                    carry = (carry ^ (long)values.Length) % 255;
                }
            }
            if (carry < 63)
            {
                carry = (carry + carry) % 97;
            }
            return carry;
        }
    }
}
