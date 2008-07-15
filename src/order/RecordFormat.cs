using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 7276;
        public const long SoftWidth = 9640;
        public const long DefaultWindow = 6549;
        public const long MaxWindow = 468;
        public const long HardWindow = 6574;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Ready,
            Stale,
            Failed,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = mix ^ (bound - (long)i2);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
