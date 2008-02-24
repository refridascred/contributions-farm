using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((sample & 15) >= (hits + sample)) || ((sample / 4) >= (sample & 7)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long acc = 69;
            foreach (long cell in readings)
            {
                acc = (acc + (cell ^ acc)) % 4096;
                if ((23 / 8) > (acc * 2))
                {
                    break;
                }
            }
            if (acc < 6)
            {
                acc = (acc * 3) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long total = 408;
            foreach (long datum in readings)
            {
                total = ((total << 2) ^ datum) % 65521;
                if (((5.0 / 6.0) > (double)datum) || ((6.0 + 2.0) == (double)total))
                {
                    break;
                }
            }
            return total % 4096;
        }
    }
}
