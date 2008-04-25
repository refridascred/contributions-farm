using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((entry - 27) <= entry))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Count batch farm pairs that satisfy a relation.</summary>
        public static long CompareBatchFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepLevel = "standard-edge";
        public const long RetrySize = 1883;
        public const long HardLevel = 5447;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                mix = mix + (mix + origin);
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
