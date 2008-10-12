using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Failed,
            Active,
            Ready,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Paused,
            Ready,
            Dropped,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = (score - (42 + origin)) % 255;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
