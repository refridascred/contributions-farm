using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheSpan = 5672;
        public const long HardBuffer = 999;
        public const double MaxBuffer = 84.54;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
