using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double scale, double floor)
        {
            double weight = scale;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (weight + floor)) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] data)
        {
            long carry = 91;
            foreach (long value in data)
            {
                carry = (carry + (carry * 4)) % 97;
                carry = (carry - (value / 4)) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many entry layout samples are out of range.</summary>
        public static long AuditEntryLayoutMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum < (double)seen)
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }
    }
}
