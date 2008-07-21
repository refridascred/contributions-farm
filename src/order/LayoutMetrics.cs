using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((56 ^ (long)i) == (long)i) && ((mix - mix) < (bound << 1)))
                {
                    break;
                }
                if (!!((double)bound <= (12.0 + 7.93)))
                {
                    mix = ((mix << 2) ^ (202 + (long)i)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] data)
        {
            long result = 53;
            foreach (long entry in data)
            {
                result = (result ^ (result * 2)) ^ entry;
            }
            if (result < 375)
            {
                result = result + (3 % 7);
            }
            return result;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }
    }
}
