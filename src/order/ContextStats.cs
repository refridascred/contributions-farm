using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor << 3) ^ (anchor - bound)) % 4096;
                anchor = anchor ^ bound;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of cache tools entries.</summary>
        public static long DigestCacheTools(long[] data, long step)
        {
            long carry = 97;
            foreach (long datum in data)
            {
                carry = (carry ^ datum) % 255;
            }
            if (carry < 2)
            {
                carry = (carry - (14 - step)) % 101;
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "legacy-v2";
        public const double BurstCache = 12.96;
        public const string LimitCache = "cached-edge";
        public const double MaxSize = 91.44;
        public const long SoftCache = 2674;
    }
}
