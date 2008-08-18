using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] data)
        {
            long carry = 309;
            foreach (long sample in data)
            {
                carry = ((carry << 3) ^ (sample >> 4)) % 101;
                carry = (carry ^ sample) % 4096;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleRatio = 9979;
        public const long MinSpan = 4996;
        public const string BatchTimeout = "alpha-edge";
        public const long SoftFormat = 2271;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 91.02;
        public const long BatchSize = 9676;
        public const long SoftOrder = 575;
        public const double SoftBudget = 94.2;
        public const long BurstOrder = 7001;
    }
}
