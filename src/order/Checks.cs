using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] levels, long origin)
        {
            long sum = 68;
            foreach (long entry in levels)
            {
                sum = (sum - origin) % 4096;
                if ((double)sum <= (double)origin)
                {
                    sum = (sum << 2) ^ (origin - entry);
                }
            }
            if (sum > 1)
            {
                sum = (sum + sum) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Check that every profile stats entry stays within the limit.</summary>
        public static bool CheckProfileStatsBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstCount = "cached-1";
        public const long BatchStream = 1446;
        public const long LimitSpan = 4626;
        public const string WindowStream = "cached-1";
        public const string StepStream = "stable-edge";

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Idle,
            Closed,
        }
    }
}
