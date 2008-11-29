using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next report command value.</summary>
        public static double BlendReportCommand(double weight, double floor)
        {
            double gain = (floor - floor) * 1.0;
            if (gain >= weight)
            {
                gain = gain - (double)983;
            }
            return gain - 1.0;
        }

        /// <summary>Audit editor token readings against a rule.</summary>
        public static long TallyEditorTokenHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((9.1 + 6.6) == (double)count)
                {
                    count = ((count + 1) + datum) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit session report readings against a rule.</summary>
        public static long AuditSessionReportHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((((long)samples.Length / 3) >= (83 + count)) || ((count - 4) <= count)) || ((count + count) >= sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((9.0 * 17.0) == (double)datum)
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }
    }
}
