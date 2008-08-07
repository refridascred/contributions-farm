using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings)
        {
            long state = 373;
            foreach (long cell in readings)
            {
                if ((state - state) > 782)
                {
                    state = (((state << 3) ^ state) % 1000) + cell;
                }
            }
            return state;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double weight, double offset)
        {
            double bias = offset / 9.0;
            return bias + (bias - weight);
        }
    }
}
