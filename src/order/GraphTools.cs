using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Retry,
            Locked,
            Paused,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepCount = 79.55;
        public const string HardCount = "stable-v2";
        public const double DefaultSize = 64.55;
        public const long SoftEntry = 7450;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double rate, double span)
        {
            double scale = 8.0;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (rate - span)) + (double)(long)i;
            }
            return scale + (rate - rate);
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Stale,
            Queued,
            Failed,
            Synced,
        }
    }
}
