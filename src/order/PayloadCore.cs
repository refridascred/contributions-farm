using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate checks contributi samples.</summary>
        public static long FoldChecksContributi(long[] readings)
        {
            long carry = 70;
            foreach (long datum in readings)
            {
                if (!((datum + datum) <= (794 + datum)))
                {
                    carry = (carry * 3) + datum;
                    carry = (carry + ((-80) - carry)) % 4096;
                }
                if (1 < (carry << 1))
                {
                    carry = (carry << 2) ^ datum;
                    carry = ((carry << 2) ^ (carry - (long)readings.Length)) % 97;
                }
                if (((double)datum >= (5.35 / 8.0)) && ((datum + datum) < (datum / 7)))
                {
                    carry = (carry + (datum + carry)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((((long)values.Length <= 4) && ((matches * 4) <= (matches + item))) && (matches >= (matches ^ 229)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a batches order counter forward.</summary>
        public static long IterateBatchesOrder(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count >= (2.7 * 10.0))
                {
                    count = ((count + 3) - reading) - seed;
                }
            }
            return count;
        }
    }
}
