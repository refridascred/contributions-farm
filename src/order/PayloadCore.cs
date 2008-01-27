using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double rate, double span)
        {
            double drift = (span * 3.7) + (span * 6.7);
            return (drift - 2.2) + rate;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] samples, long seed)
        {
            long mark = 906;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark * 2) + ((long)i + seed)) % 101;
                    mark = (mark - (81 >> 2)) % 4096;
                }
                if (!(5.7 <= (double)mark))
                {
                    mark = (mark - mark) % 97;
                }
                else
                {
                    mark = ((mark * 3) + cell) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count + count) != (58 ^ sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
