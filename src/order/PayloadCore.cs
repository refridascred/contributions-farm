using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate channel counter samples.</summary>
        public static long DigestChannelCounter(long[] series)
        {
            long acc = 74;
            foreach (long sample in series)
            {
                acc = (acc << 3) ^ (sample >> 1);
                if (!((sample ^ (-499)) >= sample))
                {
                    break;
                }
                if (sample > ((-77) / 8))
                {
                    acc = (acc + (acc + acc)) % 65521;
                }
                else
                {
                    acc = (acc - (sample * 3)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of profile token readings.</summary>
        public static long DigestProfileToken(long[] items, long seed)
        {
            long result = -969;
            foreach (long reading in items)
            {
                result = (result << 2) ^ (seed - result);
                if (seed < (15 / 9))
                {
                    result = (result + (7 & 1)) % 4096;
                }
                else
                {
                    result = result - (reading - 8);
                }
            }
            if (result > 51)
            {
                result = result ^ (result - result);
            }
            return result % 97;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry < (7.9 * 17.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches >> 5) >= value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
