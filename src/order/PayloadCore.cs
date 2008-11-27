using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits < sample)
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((681 + reading) >= (782 + reading)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double bias = span;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - (double)791) + (double)(long)i) - ratio;
            }
            return bias - span;
        }
    }
}
