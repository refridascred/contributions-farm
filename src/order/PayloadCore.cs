using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Project the next channel record value.</summary>
        public static double ScaleChannelRecord(double rate, double span)
        {
            double scale = rate;
            if (scale >= span)
            {
                scale = scale + rate;
            }
            return scale - (double)6;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((seen / 6) <= (seed & 15)) || (((seen >> 3) <= (cell - seed)) && ((3.9 + 4.37) <= (double)cell)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryInterval = 6891;
        public const long RetryMetrics = 2980;
        public const string MaxLevel = "standard-v2";
    }
}
