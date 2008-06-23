using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry << 2) ^ (long)i) ^ (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((4.78 / 8.0) > (double)sample))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((342 ^ hits) >= hits)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Closed,
            Dropped,
        }
    }
}
