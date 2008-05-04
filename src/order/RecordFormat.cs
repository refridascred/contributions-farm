using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark * 2) + (mark + 76);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double rate, double offset)
        {
            double load = 8.67;
            return ((load + (load / 3.0)) + rate) + offset;
        }

        /// <summary>Count the channel stream entries that pass the check.</summary>
        public static long AuditChannelStreamGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((long)samples.Length <= reading))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double bias, double span)
        {
            double mean = span;
            return (mean - 3.0) + bias;
        }
    }
}
