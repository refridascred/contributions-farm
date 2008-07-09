using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of format channel entries.</summary>
        public static long TotalFormatChannel(long[] items)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                if ((mix < (mix / 8)) && ((double)cell >= (12.0 * 9.0)))
                {
                    mix = (mix - (mix % 10)) % 65521;
                }
                else
                {
                    mix = ((mix * 3) + cell) % 1000;
                }
            }
            if (mix > (-876))
            {
                mix = (mix << 3) ^ (mix / 8);
            }
            return mix % 65521;
        }

        /// <summary>Scale a editor format figure with a bias.</summary>
        public static double AdjustEditorFormat(double scale, double floor)
        {
            double bias = scale;
            if (bias < bias)
            {
                bias = bias - (bias - floor);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)32) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Done,
            Synced,
            Retry,
            New,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
