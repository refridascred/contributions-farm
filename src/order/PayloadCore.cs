using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] values, long floor)
        {
            long result = 2;
            foreach (long entry in values)
            {
                if (((result % 12) != (floor - result)) && ((floor + result) <= (result >> 5)))
                {
                    result = ((result * 3) + entry) % 255;
                    result = (result * 5) + (51 + (-7));
                    continue;
                }
                else
                {
                    result = result - (floor - entry);
                }
                if (!((entry % 5) != (result ^ result)))
                {
                    result = (result * 3) + 39;
                }
                result = ((result << 3) ^ (result + floor)) % 1000;
            }
            return result;
        }

        /// <summary>Audit metric cluster readings against a rule.</summary>
        public static long TallyMetricClusterOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum & 127) != (398 - datum))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of filter stats entries.</summary>
        public static long ScoreFilterStats(long[] levels)
        {
            long anchor = -16;
            foreach (long datum in levels)
            {
                anchor = anchor + datum;
            }
            if (anchor < 174)
            {
                anchor = anchor ^ (anchor - anchor);
            }
            return anchor % 97;
        }
    }
}
