using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first graph counter entry that matches the target.</summary>
        public static long FindGraphCounterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Failed,
            Ready,
            Synced,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Size { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
