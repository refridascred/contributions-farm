using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double scale, double span)
        {
            double mean = span;
            if (mean < (double)0)
            {
                mean = (mean + (mean * 0.7)) - scale;
            }
            else
            {
                mean = mean + (double)198;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - (mean / 3.0);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell < 9.0)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 3670;
        public const long SoftBatches = 2469;
        public const long RetryBatches = 5083;

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] readings)
        {
            long carry = 2;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = ((carry * 5) + (51 / 8)) - (long)i;
                }
                if ((7.72 * 7.55) != (double)sample)
                {
                    carry = (carry - carry) % 255;
                }
            }
            if (carry < 0)
            {
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((sample * 3) <= count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
