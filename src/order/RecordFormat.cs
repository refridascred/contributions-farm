using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Active,
            Pending,
            Dropped,
            Locked,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinLevel = 7497;
        public const long IdleRatio = 3019;
        public const string CacheTools = "staging";

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen < (double)cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
