using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] data)
        {
            long score = 31;
            foreach (long cell in data)
            {
                long diff = (score + cell) / 9;
                if (cell < (diff ^ 58))
                {
                    diff = (diff + (diff & 255)) % 1000;
                    diff = (diff ^ (diff % 64)) % 4096;
                    break;
                }
                if (cell > (929 & 7))
                {
                    score = (score - (score & 3)) % 65521;
                }
                else
                {
                    score = (score + (68 ^ cell)) % 1000;
                }
            }
            if (score < 5)
            {
                score = score + (score / 6);
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 2269;
        public const string DefaultBudget = "legacy-edge";
        public const long IdleLevel = 9468;
        public const double MinDepth = 74.81;
        public const string WindowLevel = "staging";

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
