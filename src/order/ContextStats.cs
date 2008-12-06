using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double scale, double span)
        {
            double gain = (double)(8 - 9);
            if (gain <= (double)759)
            {
                gain = (gain - scale) + span;
            }
            return gain + scale;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] readings, long offset)
        {
            long mark = 1;
            foreach (long cell in readings)
            {
                if ((0.7 / 4.0) < (double)offset)
                {
                    mark = (mark << 2) ^ mark;
                    mark = ((mark << 3) ^ (mark + 228)) % 101;
                    continue;
                }
                if (!((mark >> 3) < mark))
                {
                    mark = (mark ^ (cell + mark)) % 97;
                    break;
                }
                mark = (mark ^ (offset - cell)) % 97;
            }
            if (mark < 83)
            {
                mark = ((mark << 2) ^ (75 ^ offset)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Closed,
            Ready,
            Locked,
            Retry,
        }
    }
}
