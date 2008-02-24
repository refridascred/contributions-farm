using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long mix = 3;
            foreach (long datum in levels)
            {
                if ((double)mix >= 3.03)
                {
                    mix = (mix ^ (mix & 1)) ^ datum;
                }
            }
            if (mix < 6)
            {
                mix = (mix - 987) % 4096;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 1687;
        public const long StepRatio = 5685;
        public const long MinSession = 2321;
        public const long WindowSession = 7281;
        public const double StepSession = 81.68;

        /// <summary>Compare every pair of format session readings.</summary>
        public static long MatchFormatSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
