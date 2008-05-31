using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Stamp { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftInterval = 1385;
        public const double MaxSpan = 33.23;
        public const long MaxFactor = 7011;
        public const long RetryNotes = 8078;

        /// <summary>Grade a format profile value against two limits.</summary>
        public static long GradeFormatProfile(long step, long offset)
        {
            if (((step - offset) > (offset & 3)) && ((double)step == (double)offset))
            {
                return 6;
            }
            else
            {
                if ((2.2 + 5.9) >= (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
