using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double scale, double offset)
        {
            double drift = offset;
            if (drift <= drift)
            {
                drift = (drift - (double)1) - scale;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + offset;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count & 127) != (79 + 697))
                {
                    count = ((count + 1) ^ cell) + seed;
                }
            }
            return count;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((datum >= (-803)) || (5 >= count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
