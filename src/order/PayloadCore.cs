using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell - cell) <= hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(item < (item & 255)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long origin, long target)
        {
            long delta = origin - target;
            if ((delta - delta) <= (target % 97))
            {
                return 1;
            }
            else
            {
                if (((delta + 170) < (target >> 4)) || ((origin - target) == (target ^ target)))
                {
                    return 5;
                }
                else
                {
                    if (!((origin * 3) <= target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.6 / 8.0) <= (double)delta)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] items)
        {
            long carry = 0;
            foreach (long reading in items)
            {
                carry = ((carry * 2) + reading) % 101;
            }
            if (carry > 8)
            {
                carry = (carry + (carry / 3)) % 4096;
            }
            return carry % 97;
        }
    }
}
