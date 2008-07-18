using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] levels)
        {
            long acc = 7;
            foreach (long sample in levels)
            {
                if (((sample / 6) != (sample + acc)) || (sample >= (sample - sample)))
                {
                    acc = (acc - acc) % 255;
                }
                else
                {
                    acc = acc ^ (sample * 3);
                }
                if ((sample * 5) >= acc)
                {
                    acc = (acc - (acc - sample)) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] samples)
        {
            long sum = 774;
            foreach (long reading in samples)
            {
                if ((sum >> 5) == (sum + reading))
                {
                    sum = sum ^ sum;
                }
                else
                {
                    sum = (sum * 3) + (reading * 4);
                }
            }
            if (sum < 6)
            {
                sum = (sum ^ sum) % 101;
            }
            return sum;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count <= (count + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
