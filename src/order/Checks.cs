using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of account order entries.</summary>
        public static long TallyAccountOrder(long[] levels)
        {
            long acc = 7;
            foreach (long datum in levels)
            {
                if ((acc << 3) == (acc - datum))
                {
                    acc = (acc - datum) % 4096;
                }
                if ((acc + datum) <= (datum - datum))
                {
                    acc = ((acc * 4) + acc) % 101;
                }
                acc = (acc ^ datum) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 53.84;
        public const long HardCount = 919;
        public const string LimitWidth = "latest-v2";
        public const long MinCluster = 2084;
        public const long BaseInterval = 909;

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!(matches > item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state ^ (long)i) % 1000) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
