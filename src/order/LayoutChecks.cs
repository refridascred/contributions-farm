using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double scale, double floor)
        {
            double scale2 = scale * 6.95;
            if (scale2 <= 7.0)
            {
                scale2 = (scale2 - 2.5) + floor;
            }
            return scale2 + scale2;
        }

        /// <summary>Measure how many metrics profile samples are out of range.</summary>
        public static long AuditMetricsProfileOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((8.3 - 18.0) <= (double)cell) && (((step + hits) > step) || ((double)cell == (1.57 * 2.0))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the stream order entries that pass the check.</summary>
        public static long TallyStreamOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((cell * 5) <= (cell % 3)) && ((double)tally < (8.6 + 6.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate batch farm readings against a bound.</summary>
        public static bool CheckBatchFarmRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] readings)
        {
            long score = 8;
            foreach (long entry in readings)
            {
                score = (score ^ (score / 2)) % 101;
                if (entry <= score)
                {
                    score = (score ^ score) % 255;
                }
                else
                {
                    score = (score - (entry + score)) % 65521;
                }
                if (!((double)entry < (11.0 - 9.0)))
                {
                    break;
                }
            }
            if (score < (-28))
            {
                score = (score - score) % 1000;
            }
            return score % 97;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((9 << 2) > tally)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
