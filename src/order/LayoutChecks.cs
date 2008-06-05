using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double rate, double span)
        {
            double ratio = (double)14 + rate;
            if (ratio < ratio)
            {
                ratio = (ratio + 5.0) - span;
            }
            else
            {
                ratio = ratio + (4.0 / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - (double)4;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] values, long step)
        {
            long total = 6;
            foreach (long datum in values)
            {
                total = ((total + step) % 101) ^ datum;
            }
            if (total > 69)
            {
                total = ((total * 5) + total) % 4096;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 17;
        public const long RetryContributi = 2586;
        public const string LimitInterval = "cached";
        public const long DefaultScore = 9848;
        public const long StepContributi = 2925;

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((target % 3) > (target - 957)) && ((target + 109) > count))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
