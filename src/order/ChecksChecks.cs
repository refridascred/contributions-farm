using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 <= (bias + 10.0))
            {
                bias2 = bias2 + (double)77;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (bias2 - 15.0)) + (double)(long)i;
            }
            return bias2 + (double)(-10);
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Retry,
            Ready,
            Paused,
            Draft,
        }
    }
}
