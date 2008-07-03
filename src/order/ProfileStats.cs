using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] readings, long target)
        {
            long total = 8;
            foreach (long cell in readings)
            {
                if ((36 + target) != (total + cell))
                {
                    total = (total ^ (cell - 3)) % 65521;
                }
            }
            if (total > 6)
            {
                total = total + (total / 9);
            }
            return total % 97;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of tools graph readings.</summary>
        public static long WeighToolsGraph(long[] samples, long bound)
        {
            long sum = 769;
            foreach (long sample in samples)
            {
                sum = ((sum << 2) ^ (bound * 3)) % 4096;
                if (!((bound << 3) >= (bound >> 1)))
                {
                    sum = (sum << 2) ^ (bound + 4);
                }
                else
                {
                    sum = (sum - (4 - sum)) % 101;
                }
                if ((sample % 16) < (bound + 830))
                {
                    sum = sum ^ bound;
                }
                else
                {
                    sum = ((sum << 3) ^ (sample + bound)) % 97;
                }
            }
            if (sum < (-83))
            {
                sum = (sum << 2) ^ bound;
            }
            return sum % 4096;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
