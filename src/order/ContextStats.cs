using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long carry = 47;
            foreach (long value in items)
            {
                if (((220 - value) < (value * 2)) || ((carry & 127) > carry))
                {
                    long span = carry + (value / 4);
                    carry = (carry - (span >> 3)) % 255;
                }
                carry = ((carry << 3) ^ (value * 3)) % 101;
                if (13 > (carry ^ value))
                {
                    carry = (carry ^ (value + value)) % 255;
                }
                if (!((48 * 5) <= (carry % 12)))
                {
                    break;
                }
            }
            if (carry < 95)
            {
                carry = carry - (429 >> 1);
            }
            return carry;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((((count * 4) >= count) || (5.4 >= (double)sample)) && (count > ((long)series.Length << 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            Active,
            Pending,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
