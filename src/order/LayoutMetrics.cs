using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit counter filter readings against a rule.</summary>
        public static long AuditCounterFilterMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count ^ item) > (count * 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a farm order reading by value.</summary>
        public static long LookupFarmOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
