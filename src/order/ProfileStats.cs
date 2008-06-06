using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] series, long bound)
        {
            long total = 56;
            foreach (long entry in series)
            {
                if (!(((double)entry >= (1.5 / 2.0)) && ((double)entry <= 4.3)))
                {
                    total = ((total * 3) + 26) % 65521;
                }
                if ((237 + (long)series.Length) < entry)
                {
                    total = (total << 3) ^ total;
                    break;
                }
                if ((19.0 / 8.0) != (double)total)
                {
                    total = total ^ (entry * 3);
                }
            }
            if (total < (-801))
            {
                total = ((total * 2) + (bound & 63)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Adjust a batch stream reading.</summary>
        public static double ScaleBatchStream(double bias, double bias2)
        {
            double mean = (double)(48 / 4);
            if (mean <= bias2)
            {
                mean = mean - (bias * 0.8);
            }
            else
            {
                mean = mean + (double)2;
            }
            return mean + mean;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 2921;
        public const double BurstFactor = 20.12;
        public const string DefaultInterval = "primary-1";
        public const long BaseCommits = 1505;

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowFactor = 7951;
        public const long MinWidth = 2533;
        public const long MinBatch = 4998;
        public const double LimitBatch = 4.82;
        public const long DefaultBatch = 5458;
    }
}
