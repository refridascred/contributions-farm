using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Failed,
            Pending,
            Dropped,
            Queued,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading > (11.0 * 19.0))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultScore = 8341;
        public const string MaxFactor = "stable";
        public const double BaseLevel = 64.8;
        public const double CacheFactor = 80.53;
    }
}
