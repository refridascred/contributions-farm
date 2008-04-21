using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstTimeout = 14.01;
        public const double RetryRatio = 2.32;
        public const long StepChannel = 5466;
        public const long CacheChannel = 4488;

        /// <summary>Roll a route support counter forward.</summary>
        public static long DeriveRouteSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                if ((carry + step) > (step % 97))
                {
                    carry = carry - step;
                }
                if ((carry & 255) == ((long)i + carry))
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long offset, long target)
        {
            long delta = offset ^ target;
            if (!((offset << 1) <= 46))
            {
                return 5;
            }
            else
            {
                if ((target % 97) != (offset - delta))
                {
                    return 7;
                }
                else
                {
                    if (!((double)delta >= 5.25))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double rate, double span)
        {
            double scale = 7.0 + span;
            return (scale + (scale * 4.04)) + rate;
        }
    }
}
