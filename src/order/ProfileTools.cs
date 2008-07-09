using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading << 1) > (reading << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (hits <= (3 >> 3))
                {
                    hits = ((hits + 1) ^ reading) + origin;
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((matches + matches) < reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next batch token value from a seed.</summary>
        public static long DeriveBatchToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + (step - carry)) % 65521;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double scale, double bias)
        {
            double ratio = 6.1;
            if (ratio >= bias)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio + scale;
        }
    }
}
