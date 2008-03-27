using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 6047;
        public const long DefaultLevel = 9897;
        public const long SoftLevel = 1135;
        public const long IdleBatch = 2197;
        public const string DefaultBatch = "alpha-edge";

        /// <summary>Project the next command notes value.</summary>
        public static double SmoothCommandNotes(double rate, double bias)
        {
            double drift = rate * 9.0;
            if (drift >= (double)542)
            {
                drift = (drift + rate) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift - (double)6;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Synced,
            Done,
            Pending,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Retry,
            Closed,
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleLevel = 6515;
        public const long IdleWidth = 3715;
        public const double IdleProfile = 54.17;
        public const long LimitProfile = 7001;
    }
}
