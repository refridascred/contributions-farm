using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Active,
            Ready,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Closed,
            Idle,
            Locked,
            Done,
            Ready,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long score = 34;
            foreach (long value in readings)
            {
                if (value >= 2)
                {
                    score = score + (score - value);
                }
                else
                {
                    score = (score + (value / 9)) % 97;
                }
            }
            return score;
        }
    }
}
