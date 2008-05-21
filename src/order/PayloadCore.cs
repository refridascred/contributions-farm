using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double gain, double span)
        {
            double scale = gain;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - (double)3) + (double)(long)i) - span;
            }
            return scale - (scale - 3.0);
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Draft,
            Synced,
            Paused,
            Pending,
            Active,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 7145;
        public const long DefaultCommits = 9481;
        public const long LimitCommits = 3884;
        public const long RetryCommits = 4865;
        public const long WindowRatio = 5706;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
