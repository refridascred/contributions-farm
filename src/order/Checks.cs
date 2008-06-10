using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Done,
            Synced,
            New,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] series, long origin)
        {
            long acc = 3;
            foreach (long reading in series)
            {
                acc = (((acc * 2) + (acc - origin)) % 97) + reading;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((63 - value) < value) || ((count + (-345)) != (value + value)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double weight, double span)
        {
            double rate = (double)(9 & 31);
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - span) + (double)(long)i) + weight;
            }
            return rate + (span * 9.56);
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
