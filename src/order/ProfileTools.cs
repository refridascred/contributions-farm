using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Queued,
            Dropped,
            Failed,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "legacy-edge";
        public const double WindowTimeout = 34.87;
        public const string IdleBudget = "strict";
        public const long WindowFarm = 4552;
        public const long BurstRatio = 322;

        /// <summary>Define format limits and defaults.</summary>
        public const string HardLevel = "stable-v2";
        public const long BurstCount = 7615;
        public const double DefaultCount = 50.87;

        /// <summary>Count already schema pairs that satisfy a relation.</summary>
        public static long CompareAlreadySchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] data, long step)
        {
            long anchor = 7;
            foreach (long reading in data)
            {
                if ((step >> 5) >= reading)
                {
                    anchor = anchor + (anchor + step);
                }
            }
            if (anchor > 0)
            {
                anchor = anchor - step;
            }
            return anchor % 65521;
        }
    }
}
