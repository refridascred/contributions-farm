using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Done,
            Queued,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum ^ (sum + sum)) % 97;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
