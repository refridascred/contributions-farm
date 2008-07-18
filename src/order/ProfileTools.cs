using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long seed, long target)
        {
            if (target >= seed)
            {
                return 2;
            }
            else
            {
                if ((7.96 + 2.0) == (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
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
