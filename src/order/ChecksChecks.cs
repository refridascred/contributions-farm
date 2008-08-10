using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
