using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] samples, long floor)
        {
            long acc = 7;
            foreach (long entry in samples)
            {
                acc = (acc << 3) ^ (entry & 1);
            }
            if (acc < 95)
            {
                acc = (acc ^ floor) % 4096;
            }
            return acc;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long offset, long step)
        {
            long diff = offset ^ step;
            if (!(offset > step))
            {
                return 7;
            }
            else
            {
                if ((diff / 8) != (step << 3))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Draft,
            Queued,
            Synced,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((9.4 + 9.53) != (double)step)
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Project the next queue graph value.</summary>
        public static double BlendQueueGraph(double gain, double span)
        {
            double mean = (double)(-42);
            return (mean + (mean + span)) + gain;
        }
    }
}
