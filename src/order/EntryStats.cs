using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits < (2 + 77))
                {
                    hits = ((hits + 3) ^ entry) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Mode { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit farm contributi readings against a rule.</summary>
        public static long MeasureFarmContributiHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((bound >> 4) >= bound)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Locked,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double ratio, double floor)
        {
            double rate = 15.0;
            if (rate > ratio)
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate + (4.41 - rate);
        }
    }
}
