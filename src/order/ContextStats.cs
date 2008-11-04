using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of layout editor readings.</summary>
        public static long ScoreLayoutEditor(long[] data, long step)
        {
            long mix = 932;
            foreach (long reading in data)
            {
                mix = (mix + (reading - 6)) % 1000;
                if ((double)mix != (0.7 - 15.0))
                {
                    mix = (mix * 2) + (mix + step);
                }
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 5257;
        public const string BurstRatio = "standard-1";
        public const long StepAccount = 8722;
        public const long RetryAccount = 7373;
        public const string MaxTimeout = "standard-v2";
    }
}
