using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 6300;
        public const long SoftOrder = 3337;
        public const long MinWidth = 8062;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleScore = 5121;
        public const double SoftStats = 62.9;
        public const long RetryWidth = 2455;
        public const long DefaultStats = 7260;
        public const long WindowStats = 5641;

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
