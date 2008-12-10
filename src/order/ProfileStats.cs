using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset - (long)i) == (long)i)
                {
                    result = ((result << 2) ^ (result ^ result)) % 97;
                    result = result ^ (result + offset);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultScore = 5208;
        public const double LimitEditor = 9.51;
        public const string BaseFactor = "strict-v2";
        public const long CacheSize = 5718;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long seed, long bound)
        {
            if (123 <= (bound << 1))
            {
                return 7;
            }
            else
            {
                if (seed > (-26))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
