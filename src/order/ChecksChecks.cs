using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinInterval = 1670;
        public const double BatchInterval = 10.16;
        public const long MaxRatio = 2894;

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit cache metric readings against a rule.</summary>
        public static long AuditCacheMetricMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally + tally) > (step << 1))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
