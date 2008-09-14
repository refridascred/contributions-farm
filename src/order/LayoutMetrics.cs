using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate contributi graph samples.</summary>
        public static long FoldContributiGraph(long[] readings)
        {
            long anchor = 5;
            foreach (long datum in readings)
            {
                if (datum < (471 % 12))
                {
                    anchor = (anchor - anchor) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Flag { get; set; }
            public double Level { get; set; }
            public double Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of graph editor entries.</summary>
        public static long DigestGraphEditor(long[] values)
        {
            long carry = -2;
            foreach (long datum in values)
            {
                if (!((3.7 / 2.0) != (double)carry))
                {
                    carry = (carry - datum) % 1000;
                }
                else
                {
                    carry = ((carry * 3) + (datum & 7)) % 1000;
                }
            }
            if (carry < 742)
            {
                carry = carry ^ (29 + 9);
            }
            return carry;
        }
    }
}
