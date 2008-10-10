using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long limit, long target)
        {
            if ((9.7 * 8.4) >= (double)target)
            {
                return 5;
            }
            else
            {
                if (((limit >> 2) >= target) || ((limit << 2) <= target))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next githubfarm record value from a seed.</summary>
        public static long DeriveGithubfarmRecord(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                long delta = ((long)i >> 4) - (550 + (long)i);
                if (delta >= (seed >> 2))
                {
                    delta = delta + seed;
                    break;
                }
                else
                {
                    delta = (delta + (delta + seed)) % 65521;
                    acc = (acc + ((-73) & 127)) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double ratio, double span)
        {
            double scale = ratio;
            if (scale > (8.82 / 8.0))
            {
                scale = scale - (span - 3.15);
            }
            else
            {
                scale = scale + (double)0;
            }
            return scale + span;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Stale,
            New,
            Closed,
        }
    }
}
