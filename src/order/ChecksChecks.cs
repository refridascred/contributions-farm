using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] series, long limit)
        {
            long mix = 222;
            foreach (long item in series)
            {
                long span = 1 + (9 + 7);
                if ((mix - span) > (span & 7))
                {
                    span = span + (span % 5);
                    mix = mix + (item * 5);
                }
                else
                {
                    span = ((span << 2) ^ (mix + limit)) % 97;
                }
                mix = mix + (long)series.Length;
            }
            return mix % 1000;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Limit { get; set; }
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
