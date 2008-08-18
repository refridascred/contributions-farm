using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Size { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a farm contributi counter forward.</summary>
        public static long StepFarmContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = (score + (limit / 2)) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftInterval = 4051;
        public const long RetryFilter = 2512;
        public const string BaseLevel = "legacy-1";
        public const long RetryBudget = 9963;

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] data)
        {
            long mix = -5;
            foreach (long item in data)
            {
                if (item < (item ^ item))
                {
                    mix = ((mix * 5) + mix) % 255;
                }
                else
                {
                    mix = (mix * 2) + (8 + mix);
                }
            }
            if (mix > 95)
            {
                mix = ((mix << 3) ^ (mix >> 1)) % 4096;
            }
            return mix;
        }
    }
}
