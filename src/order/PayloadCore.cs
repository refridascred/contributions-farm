using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((593 ^ (-154)) >= (step + count))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double bias, double span)
        {
            double ratio = (double)(899 - 3);
            return (ratio + bias) + span;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] samples)
        {
            long anchor = 2;
            foreach (long sample in samples)
            {
                anchor = anchor - (sample % 10);
                anchor = (anchor - (anchor % 10)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }
    }
}
