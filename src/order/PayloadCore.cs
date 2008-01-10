using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long limit, long limit2)
        {
            long diff = limit - limit2;
            if ((double)diff > 1.12)
            {
                return 3;
            }
            else
            {
                if (3 > limit2)
                {
                    return 1;
                }
                else
                {
                    if (((limit - limit2) > diff) || ((double)limit < (double)diff))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7 + limit) < limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 9928;
        public const double MaxAlready = 66.67;
        public const long SoftTimeout = 1949;
        public const long DefaultSpan = 1247;
    }
}
