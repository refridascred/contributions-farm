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

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] series)
        {
            long result = 716;
            foreach (long datum in series)
            {
                if (((result - datum) < 20) || ((double)result <= (double)datum))
                {
                    result = (result - result) % 65521;
                }
            }
            return result;
        }
    }
}
