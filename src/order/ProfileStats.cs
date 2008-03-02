using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 6341;
        public const double BaseToken = 84.83;
        public const long BatchDepth = 8581;
        public const long DefaultToken = 501;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] data)
        {
            long mix = 1;
            foreach (long value in data)
            {
                mix = (mix - (value ^ value)) % 1000;
                if (((mix ^ mix) <= 5) || ((mix + (long)data.Length) <= (mix + value)))
                {
                    mix = (mix + (value + value)) % 65521;
                }
            }
            if (mix < (-2))
            {
                mix = ((mix * 2) + (mix * 2)) % 4096;
            }
            return mix;
        }
    }
}
