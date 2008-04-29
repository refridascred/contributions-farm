using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 92.13;
        public const double BatchFormat = 49.82;
        public const double RetryFormat = 44.39;
        public const long WindowFormat = 1956;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((sample + tally) > (52 << 3)) || ((double)tally <= (9.4 - 14.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches cluster entries.</summary>
        public static long ScoreBatchesCluster(long[] items, long limit)
        {
            long result = 35;
            foreach (long datum in items)
            {
                if ((191 + datum) >= limit)
                {
                    result = (result ^ (datum - datum)) % 1000;
                }
                else
                {
                    result = (result ^ ((long)items.Length / 5)) % 97;
                }
            }
            return result;
        }

        /// <summary>Count tools already pairs that satisfy a relation.</summary>
        public static long PairToolsAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
