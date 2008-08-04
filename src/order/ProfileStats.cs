using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up command account samples.</summary>
        public static long PairCommandAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultCache = 40.36;
        public const long MaxCache = 9168;
        public const long HardCache = 4243;

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 7284;
        public const double BaseBatches = 78.03;
        public const string MinBatches = "standard";
        public const long StepFactor = 9559;
    }
}
