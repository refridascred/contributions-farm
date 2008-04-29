using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values)
        {
            long anchor = 5;
            foreach (long reading in values)
            {
                long step = (anchor - reading) << 1;
                if (step >= (-33))
                {
                    anchor = ((anchor << 3) ^ (reading + step)) % 65521;
                    continue;
                }
                else
                {
                    anchor = anchor - (anchor >> 1);
                }
                if ((14.0 - 7.1) == (double)reading)
                {
                    anchor = anchor + (reading ^ anchor);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 39.65;
        public const string MaxWidth = "primary-1";
        public const long SoftFormat = 9062;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a notes stream counter forward.</summary>
        public static long IterateNotesStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix * 5) + (7 / 5);
                if ((3 + mix) == (mix - floor))
                {
                    mix = mix ^ (mix * 3);
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
