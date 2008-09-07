using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Locked,
            Stale,
            Done,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinOrder = "legacy";
        public const long StepOrder = 8293;
        public const string HardOrder = "primary-edge";
        public const long LimitOrder = 9124;
        public const long WindowOrder = 9197;

        /// <summary>Find the first checks batches entry that matches the target.</summary>
        public static long FindChecksBatchesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
