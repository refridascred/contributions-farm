using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftFactor = 65.67;
        public const double WindowCache = 27.84;
        public const long BatchCount = 6331;
        public const long BaseCount = 7013;
        public const long IdleScore = 5499;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((datum ^ datum) < (tally * 3)) || ((double)tally >= (7.4 - 7.94))) || ((datum + 848) == (datum << 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count metrics graph pairs that satisfy a relation.</summary>
        public static long PairMetricsGraphCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
