using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double rate, double span)
        {
            double weight = rate;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (span + weight)) + (double)(long)i;
            }
            return weight + (weight * 3.0);
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] samples, long step)
        {
            long sum = 5;
            foreach (long entry in samples)
            {
                if (((9.0 - 7.2) != (double)sum) || ((double)sum == (double)entry))
                {
                    sum = ((sum * 5) + entry) + step;
                }
            }
            if (sum < 294)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 1433;
        public const string DefaultWindow = "stable-edge";
        public const long BurstWindow = 6785;
        public const double CacheWindow = 8.19;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
