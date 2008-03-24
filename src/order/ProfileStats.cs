using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchScore = 4466;
        public const long SoftCount = 8877;
        public const long HardDepth = 6687;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Dropped,
            Draft,
            Closed,
        }

        /// <summary>Fold a list of counter batch readings.</summary>
        public static long FoldCounterBatch(long[] data, long target)
        {
            long state = 30;
            foreach (long datum in data)
            {
                if ((state / 9) <= target)
                {
                    state = (state - (696 + datum)) % 1000;
                }
            }
            return state;
        }
    }
}
