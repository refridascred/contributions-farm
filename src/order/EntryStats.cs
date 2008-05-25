using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate session profile samples.</summary>
        public static long ScoreSessionProfile(long[] samples)
        {
            long carry = 0;
            foreach (long sample in samples)
            {
                carry = ((carry * 3) + (3 * 5)) - sample;
            }
            return carry;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Paused,
            Queued,
            Locked,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Count { get; set; }
            public bool Size { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
