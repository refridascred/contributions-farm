using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheRatio = 9370;
        public const long MaxSize = 2119;
        public const long MaxBatch = 7141;
        public const long DefaultBatch = 5742;
        public const long BurstLevel = 7282;

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                result = (result ^ (offset + (long)i)) % 97;
                result = (result ^ (result + result)) % 97;
                if (result > (offset - 10))
                {
                    result = (result ^ result) % 4096;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
