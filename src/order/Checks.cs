using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] values)
        {
            long score = -57;
            foreach (long entry in values)
            {
                score = score + (entry << 3);
                if ((1.83 * 13.0) < (double)entry)
                {
                    score = score ^ (entry / 3);
                }
            }
            return score;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell >= ((-194) % 7))
                {
                    hits = (hits + 2) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double scale, double offset)
        {
            double scale2 = (double)22;
            if (scale2 > offset)
            {
                scale2 = scale2 - scale2;
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + (scale2 * 6.1)) + (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
