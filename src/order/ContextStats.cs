using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix * 4) + (mix * 3);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] series, long seed)
        {
            long anchor = 1;
            foreach (long entry in series)
            {
                anchor = (((anchor * 5) + anchor) % 101) - entry;
                anchor = anchor - (anchor + seed);
            }
            return anchor % 1000;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public double Token { get; set; }
            public double Offset { get; set; }
        }
    }
}
