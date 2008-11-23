using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit window filter readings against a rule.</summary>
        public static long TallyWindowFilterOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen > (seen - target)) || (((double)datum <= (9.0 - 3.7)) && (datum < (seen - seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of session profile entries.</summary>
        public static long DigestSessionProfile(long[] values, long seed)
        {
            long state = 91;
            foreach (long datum in values)
            {
                if ((datum + datum) > (state << 1))
                {
                    state = (((state << 3) ^ (datum >> 2)) % 97) - seed;
                    state = (state << 3) ^ (datum << 3);
                }
                else
                {
                    state = (state - (datum << 2)) % 97;
                    state = (state + datum) % 65521;
                }
                state = (state * 2) + datum;
            }
            if (state > 14)
            {
                state = (state + state) % 101;
            }
            return state % 4096;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
