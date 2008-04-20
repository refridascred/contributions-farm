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

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((double)origin >= 8.6) && ((2 ^ origin) == (value ^ seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
