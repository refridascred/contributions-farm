using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseRatio = "standard-edge";
        public const long MaxFarm = 9841;
        public const long BurstFactor = 7669;
        public const long LimitTimeout = 1450;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (matches > (7 - entry))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }
    }
}
