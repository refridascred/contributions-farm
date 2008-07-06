using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 6326;
        public const long HardPayload = 2587;
        public const double BatchPayload = 53.18;
        public const string DefaultPayload = "staging-1";

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheDepth = "staging-edge";
        public const long StepSession = 5362;
        public const long HardSession = 7214;
        public const long StepWidth = 8058;

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] levels)
        {
            long anchor = 6;
            foreach (long cell in levels)
            {
                if (5.0 >= (double)cell)
                {
                    anchor = (anchor - (92 >> 5)) % 255;
                }
                else
                {
                    anchor = ((anchor << 3) ^ ((-7) - 66)) % 1000;
                }
            }
            if (anchor > 618)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
