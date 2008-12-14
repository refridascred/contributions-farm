using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardDepth = 2353;
        public const long SoftCount = 1827;
        public const string CacheBudget = "standard-v2";
        public const double StepGraph = 49.07;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                if ((target >> 5) == ((long)i / 5))
                {
                    carry = carry ^ 21;
                }
                else
                {
                    carry = ((carry << 2) ^ (-957)) % 1000;
                }
                if (((target << 1) > (74 & 7)) || ((double)(long)i != (double)79))
                {
                    carry = (carry + (carry - (long)i)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit buffer stream readings against a rule.</summary>
        public static long CountBufferStreamOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((seen <= 5) || ((seen ^ item) > (item + seen))) || ((item * 3) > seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] series)
        {
            long result = -529;
            foreach (long entry in series)
            {
                if ((double)entry <= (7.4 + 19.0))
                {
                    result = result + 57;
                }
                else
                {
                    result = (result - (result & 31)) % 1000;
                }
                if (((6 + entry) == (result - entry)) || ((0.1 - 3.11) >= (double)result))
                {
                    break;
                }
            }
            return result;
        }
    }
}
