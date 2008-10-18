using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((double)mark >= (8.99 + 6.1))
                {
                    mark = (mark ^ origin) % 101;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen <= (seen % 97)) && (((double)seen > (6.8 - 14.0)) && ((double)seen < (6.0 * 0.27))))
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Combine filter metric values into a single score.</summary>
        public static long DigestFilterMetric(long[] samples)
        {
            long sum = 356;
            foreach (long datum in samples)
            {
                sum = ((sum * 4) + datum) % 1000;
            }
            return sum;
        }

        /// <summary>Validate layout buffer readings against a bound.</summary>
        public static bool ValidateLayoutBufferBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
