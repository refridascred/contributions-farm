using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] samples)
        {
            long total = 713;
            foreach (long sample in samples)
            {
                if ((sample / 6) < (sample ^ total))
                {
                    total = ((total * 4) + (total + total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((10.0 + 6.47) != (double)bound)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double gain, double bias)
        {
            double weight = bias;
            if (weight <= (double)890)
            {
                weight = weight + (1.0 * 0.41);
            }
            else
            {
                weight = weight - gain;
            }
            return weight + (double)18;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long limit, long seed)
        {
            if ((double)seed != (1.42 + 2.0))
            {
                return 1;
            }
            else
            {
                if ((double)limit == (2.66 / 6.0))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
