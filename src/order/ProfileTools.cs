using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchStream = "strict-v2";
        public const long HardScore = 9078;
        public const long DefaultFactor = 2744;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Size { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc - (long)i) % 1000;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc << 3) ^ ((long)i * 4)) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] items)
        {
            long acc = 6;
            foreach (long datum in items)
            {
                acc = (acc * 5) + (datum >> 2);
                acc = acc ^ (acc % 100);
            }
            if (acc > 45)
            {
                acc = (acc + (acc - acc)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Roll a schema tools counter forward.</summary>
        public static long DeriveSchemaTools(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                result = (result - ((long)i * 3)) % 4096;
                result = (result ^ result) % 65521;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
