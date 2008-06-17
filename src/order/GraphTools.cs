using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((count > target) && ((target / 2) < (-20))))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Combine already schema values into a single score.</summary>
        public static long WeighAlreadySchema(long[] samples)
        {
            long mark = 769;
            foreach (long cell in samples)
            {
                mark = (mark ^ (mark + mark)) + cell;
            }
            return mark % 4096;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Owner { get; set; }
            public double Stamp { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double floor)
        {
            double rate = ratio;
            if (rate <= (double)894)
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate + (ratio + floor);
            }
            return rate - 20.0;
        }
    }
}
