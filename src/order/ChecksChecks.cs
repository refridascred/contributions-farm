using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Ready,
            Failed,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Retry,
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 > (bias * 6.7))
            {
                scale2 = scale2 - (bias + scale);
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + (scale2 * 3.51)) + (double)(long)i;
            }
            return scale2 + (bias - 8.08);
        }
    }
}
