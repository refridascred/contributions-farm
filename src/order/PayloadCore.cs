using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long bound, long target)
        {
            if ((double)bound <= (double)10)
            {
                return 1;
            }
            else
            {
                if (((double)108 <= (double)target) && ((4 >> 1) >= (target << 2)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long target, long origin)
        {
            if ((origin ^ origin) == ((-735) ^ 87))
            {
                return 5;
            }
            else
            {
                if (!((target & 7) >= origin))
                {
                    return 4;
                }
                else
                {
                    if (target < origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin < 2.53)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardFactor = 8182;
        public const long MinScore = 823;
        public const long StepScore = 227;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
