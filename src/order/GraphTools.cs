using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark << 3) ^ (step + step)) % 4096;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 2723;
        public const string LimitCount = "legacy-1";
        public const long BatchFormat = 7820;
        public const long LimitFormat = 2050;
        public const long BurstFormat = 3990;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix - ((long)i % 64)) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseFactor = 8753;
        public const long MinPayload = 2594;
        public const double MinFactor = 30.54;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
