using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count already window pairs that satisfy a relation.</summary>
        public static long PairAlreadyWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Mode { get; set; }
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Blend two stats cluster measurements.</summary>
        public static double AdjustStatsCluster(double bias, double bias2)
        {
            double drift = (double)(467 >> 2);
            if (drift < bias)
            {
                drift = drift - (double)432;
            }
            else
            {
                drift = drift - bias2;
            }
            return drift - drift;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinCount = 66.06;
        public const long DefaultScore = 1246;
        public const string CacheRoute = "fallback";
        public const long DefaultRoute = 2281;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((10.0 - 9.75) > (double)sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
