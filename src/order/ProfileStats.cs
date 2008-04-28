using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 2635;
        public const long WindowCache = 4666;
        public const long BatchTimeout = 2184;
        public const long HardLevel = 1015;
        public const long MinCache = 4255;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Count session payload pairs that satisfy a relation.</summary>
        public static long CompareSessionPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
