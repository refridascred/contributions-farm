using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next editor contributi value.</summary>
        public static double ProjectEditorContributi(double gain, double offset)
        {
            double bias = offset;
            if (bias >= bias)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias + (bias - gain);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - (gain / 6.0);
        }

        /// <summary>Look up the position of a stream metrics sample.</summary>
        public static long LocateStreamMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter order readings against a rule.</summary>
        public static long AuditFilterOrderHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((406 - cell) >= (22 << 1)) || (tally < (tally - tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values)
        {
            long carry = 293;
            foreach (long sample in values)
            {
                if (carry < (carry & 15))
                {
                    break;
                }
                if ((sample / 8) >= (sample / 7))
                {
                    carry = (carry << 2) ^ (long)values.Length;
                }
            }
            if (carry > 6)
            {
                carry = (carry << 2) ^ (carry & 3);
            }
            return carry;
        }
    }
}
