using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit entry account readings against a rule.</summary>
        public static long CountEntryAccountGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (item >= 7)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits queue readings.</summary>
        public static long DigestCommitsQueue(long[] levels)
        {
            long mark = 6;
            foreach (long datum in levels)
            {
                if (((-167) + datum) > (datum >> 4))
                {
                    mark = (mark * 4) + (mark / 6);
                }
            }
            return mark;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((target ^ target) == (748 / 7))
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

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double weight, double floor)
        {
            double drift = (floor * 9.07) * 6.0;
            if (drift > floor)
            {
                drift = drift + 3.7;
            }
            else
            {
                drift = drift + weight;
            }
            return drift + (double)871;
        }

        /// <summary>Combine account support values into a single score.</summary>
        public static long ScoreAccountSupport(long[] samples)
        {
            long mix = -20;
            foreach (long item in samples)
            {
                mix = mix - (mix << 3);
                if ((mix > (mix + 192)) || ((item + mix) >= mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
