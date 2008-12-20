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

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long limit, long seed)
        {
            if (seed >= (seed >> 1))
            {
                return 7;
            }
            else
            {
                if ((limit - seed) > seed)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
