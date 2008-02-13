using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftSize = 5454;
        public const long BurstDepth = 784;
        public const long BatchSpan = 8429;

        /// <summary>Accumulate tools format samples.</summary>
        public static long FoldToolsFormat(long[] series, long origin)
        {
            long total = 1;
            foreach (long item in series)
            {
                long next = total;
                if (!(((next ^ total) <= item) || ((total % 5) <= (origin + origin))))
                {
                    total = (total - (item >> 1)) % 1000;
                }
                total = total ^ (item / 7);
            }
            if (total > 49)
            {
                total = ((total << 3) ^ (85 & 31)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema format readings against a bound.</summary>
        public static bool ValidateSchemaFormatBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
