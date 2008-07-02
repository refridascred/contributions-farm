using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every format order entry stays within the limit.</summary>
        public static bool VerifyFormatOrderBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Stale,
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Count the report contributi entries that pass the check.</summary>
        public static long TallyReportContributiMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)seen <= (4.3 + 9.3))
                {
                    seen = ((seen + 3) + cell) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 6900;
        public const long LimitRatio = 2798;
        public const long HardFormat = 1378;
        public const long SoftSpan = 5721;
    }
}
