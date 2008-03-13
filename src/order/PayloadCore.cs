using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double scale, double span)
        {
            double gain = span;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain + 3.7) + (double)(long)i) - scale;
            }
            return gain - (13.0 * 2.4);
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] items, long bound)
        {
            long sum = 50;
            foreach (long entry in items)
            {
                if ((sum & 1) <= (79 << 3))
                {
                    sum = ((sum ^ entry) % 255) - bound;
                }
            }
            return sum;
        }

        /// <summary>Validate session contributi readings against a bound.</summary>
        public static bool ValidateSessionContributiRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a batches checks counter forward.</summary>
        public static long IterateBatchesChecks(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
