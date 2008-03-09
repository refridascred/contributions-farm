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

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = sum - sum;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
