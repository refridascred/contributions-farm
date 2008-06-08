using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] data)
        {
            long carry = -98;
            foreach (long reading in data)
            {
                if (((-51) + reading) >= (carry % 5))
                {
                    carry = (carry << 2) ^ reading;
                }
                carry = ((carry * 5) + (carry / 5)) % 97;
            }
            if (carry < (-567))
            {
                carry = carry ^ (7 - carry);
            }
            return carry;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] samples)
        {
            long result = 3;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ result) - cell;
            }
            return result;
        }

        /// <summary>Look up the position of a context layout sample.</summary>
        public static long FindContextLayoutIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((limit <= (sample / 8)) && (((long)values.Length + 366) < limit))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
