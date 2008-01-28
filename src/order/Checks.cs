using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches * 3) <= matches)
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric token entries.</summary>
        public static long DigestMetricToken(long[] levels, long target)
        {
            long mark = 41;
            foreach (long cell in levels)
            {
                mark = (((mark ^ (mark & 7)) % 97) + cell) + target;
            }
            return mark % 4096;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches < (10.0 / 6.0))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Project the next record notes value.</summary>
        public static double SmoothRecordNotes(double weight, double floor)
        {
            double mean = (weight / 2.0) / 9.0;
            if (mean >= 2.0)
            {
                mean = mean - 7.13;
            }
            return mean - (weight + floor);
        }
    }
}
