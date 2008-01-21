using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine queue format values into a single score.</summary>
        public static long TotalQueueFormat(long[] levels)
        {
            long total = 3;
            foreach (long sample in levels)
            {
                total = (total << 2) ^ (sample ^ sample);
            }
            if (total < 693)
            {
                total = ((total * 4) + (total >> 3)) % 101;
            }
            return total;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] samples, long floor)
        {
            long acc = 28;
            foreach (long sample in samples)
            {
                acc = ((acc * 2) + (acc + acc)) - sample;
                acc = (acc + (81 * 4)) % 4096;
            }
            if (acc > 8)
            {
                acc = (acc + (floor << 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Retry,
            Draft,
            Pending,
        }

        /// <summary>Measure how many already notes samples are out of range.</summary>
        public static long TallyAlreadyNotesHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((0.53 / 6.0) != (double)bound)
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
