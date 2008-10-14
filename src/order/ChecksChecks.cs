using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 2365;
        public const double SoftGraph = 9.86;
        public const string RetryGraph = "fallback-v2";
        public const long BatchGraph = 5534;

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double scale, double span)
        {
            double gain = span * 4.74;
            if (gain < 0.5)
            {
                gain = gain - (gain + scale);
            }
            return gain + 20.0;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Ready,
            Pending,
            Queued,
            Active,
            Done,
        }
    }
}
