using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Paused,
            Done,
            Retry,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long target, long offset)
        {
            if (((target / 9) <= (offset << 3)) && ((offset & 7) > (target / 6)))
            {
                return 1;
            }
            else
            {
                if (((332 + target) > offset) || ((double)target >= 0.8))
                {
                    return 2;
                }
                else
                {
                    return 8;
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
