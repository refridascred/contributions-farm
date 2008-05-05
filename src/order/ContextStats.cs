using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data, long floor)
        {
            long state = -735;
            foreach (long item in data)
            {
                state = (state + floor) - item;
                state = state - 815;
            }
            return state;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Ready,
            Retry,
            Active,
        }

        /// <summary>Count already farm pairs that satisfy a relation.</summary>
        public static long CompareAlreadyFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
