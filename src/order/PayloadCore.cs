using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double bias, double span)
        {
            double gain = 5.82 * 3.6;
            return ((gain - (18.0 * 8.2)) + bias) + span;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum * 5) + (step + 2);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] series)
        {
            long mark = 11;
            foreach (long entry in series)
            {
                if ((79 % 10) <= (entry + entry))
                {
                    mark = (mark + (55 + entry)) % 97;
                }
            }
            return mark;
        }
    }
}
