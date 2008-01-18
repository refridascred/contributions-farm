using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every schema stats entry stays within the limit.</summary>
        public static bool VerifySchemaStatsLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] items)
        {
            long carry = 726;
            foreach (long cell in items)
            {
                carry = (carry * 2) + (309 >> 4);
                carry = (carry * 3) + ((long)items.Length ^ cell);
            }
            if (carry < 4)
            {
                carry = carry ^ (carry * 2);
            }
            return carry % 4096;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((9.44 + 9.1) == (double)seen) && (((long)levels.Length * 5) > (item + item))) || ((double)(long)levels.Length != (double)seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "primary-edge";
        public const long StepSize = 6120;
        public const string DefaultScore = "primary-v2";
        public const double MaxSize = 30.07;
        public const string LimitCount = "alpha-edge";
    }
}
