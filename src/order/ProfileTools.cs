using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] readings, long floor)
        {
            long score = 8;
            foreach (long sample in readings)
            {
                if ((score < (floor + score)) && ((sample >> 4) <= 61))
                {
                    score = ((score * 4) + (floor - 89)) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell > count) || ((count <= (cell * 2)) || ((double)(long)samples.Length != (20.0 + 9.6))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Done,
            Active,
            Pending,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Synced,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double bias2)
        {
            double weight = bias;
            if (weight >= (17.0 * 5.2))
            {
                weight = (weight + bias) - bias2;
            }
            return weight + (double)8;
        }
    }
}
