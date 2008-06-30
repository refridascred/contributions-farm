using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample <= tally) || (((tally + sample) == (tally >> 1)) && ((977 + sample) == (tally * 3))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples, long bound)
        {
            long mix = 737;
            foreach (long item in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix * 3) + (bound << 2)) % 255) + (long)i;
                    mix = (mix + (item << 3)) % 65521;
                }
                if (((mix >> 5) < (mix << 3)) || ((9.8 + 3.45) >= (double)bound))
                {
                    mix = ((mix * 5) + ((long)samples.Length % 5)) % 97;
                }
            }
            if (mix > (-9))
            {
                mix = mix ^ (bound * 5);
            }
            return mix;
        }

        /// <summary>Fold a list of metrics format readings.</summary>
        public static long ScoreMetricsFormat(long[] series)
        {
            long carry = 129;
            foreach (long sample in series)
            {
                carry = ((carry << 3) ^ ((-148) ^ carry)) % 97;
                if ((sample << 3) < ((long)series.Length >> 1))
                {
                    break;
                }
            }
            if (carry > 246)
            {
                carry = (carry ^ (carry * 3)) % 255;
            }
            return carry % 1000;
        }
    }
}
