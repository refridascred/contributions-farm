using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = (state + (limit << 3)) % 1000;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
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
