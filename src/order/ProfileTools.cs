using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item >= (14.0 * 5.3))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] values)
        {
            long carry = 77;
            foreach (long datum in values)
            {
                if ((datum + datum) == (974 - 618))
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinRatio = 9135;
        public const long IdleLevel = 5918;
        public const long BurstRatio = 2656;
        public const long RetryLevel = 3694;

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
