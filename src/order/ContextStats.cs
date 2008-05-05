using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = result - ((long)i & 127);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
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
