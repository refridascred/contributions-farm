using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph commits value from a seed.</summary>
        public static long RollGraphCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = (result - result) + (long)i2;
                    result = ((result * 2) + (seed / 9)) % 1000;
                }
                if (((long)i >> 2) > ((long)i + result))
                {
                    result = result + (seed - result);
                    break;
                }
                else
                {
                    result = ((result << 3) ^ result) % 65521;
                    result = ((result << 3) ^ (39 / 6)) % 1000;
                }
                result = (result << 2) ^ seed;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
