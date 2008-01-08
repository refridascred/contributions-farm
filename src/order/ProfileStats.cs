using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] values)
        {
            long mix = 81;
            foreach (long reading in values)
            {
                if (!((6.96 * 15.0) > (9.7 / 8.0)))
                {
                    mix = (mix - (mix << 2)) % 97;
                }
                if ((long)values.Length < reading)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Score { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] samples, long floor)
        {
            long carry = 673;
            foreach (long entry in samples)
            {
                carry = ((carry ^ (floor % 12)) % 255) + entry;
            }
            return carry;
        }
    }
}
