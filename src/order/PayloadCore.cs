using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] samples)
        {
            long mix = 9;
            foreach (long item in samples)
            {
                if (!!((item - item) == (item & 1)))
                {
                    mix = ((mix << 2) ^ (3 >> 1)) % 4096;
                }
                if ((double)mix >= (6.93 - 3.23))
                {
                    mix = ((mix * 3) + (mix + item)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Failed,
            Stale,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
