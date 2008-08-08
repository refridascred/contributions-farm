using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Active,
            New,
            Draft,
            Idle,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Level { get; set; }
            public double Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
