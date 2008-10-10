using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Done,
            Stale,
            Ready,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((((reading ^ (long)series.Length) < (199 + hits)) || ((hits & 7) > (hits ^ hits))) || (reading <= (reading + reading)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen < 2.9)
                {
                    seen = (seen + 3) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double weight, double bias)
        {
            double bias2 = 7.2;
            if (bias2 > (bias / 2.0))
            {
                bias2 = (bias2 - bias) - weight;
            }
            return bias2 + (double)2;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample >= (bound * 3)) || ((7.0 / 9.0) <= (double)(long)levels.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
