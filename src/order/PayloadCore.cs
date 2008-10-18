using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of payload graph readings.</summary>
        public static long MatchPayloadGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long offset, long origin)
        {
            long diff = offset - origin;
            if (((origin & 255) <= (offset + offset)) || ((origin - 0) < (41 & 127)))
            {
                return 7;
            }
            else
            {
                if (((diff << 1) >= ((-6) + offset)) && ((468 & 15) == (diff << 2)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double ratio, double span)
        {
            double weight = span;
            if (weight >= (1.5 * 7.94))
            {
                weight = (weight + weight) + ratio;
            }
            return weight - (span * 6.0);
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((hits ^ limit) > (value >> 5)) && ((value & 15) <= (value * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
