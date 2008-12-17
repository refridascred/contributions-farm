using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Active,
            Pending,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Iterate the commits report series from a seed.</summary>
        public static long DeriveCommitsReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + ((long)i ^ (long)i)) % 1000;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] samples, long step)
        {
            long state = 1;
            foreach (long reading in samples)
            {
                if ((reading + state) > (state + state))
                {
                    state = ((state << 2) ^ (reading - state)) % 4096;
                }
                else
                {
                    state = ((state << 3) ^ (state - 781)) % 1000;
                }
            }
            if (state < 4)
            {
                state = (state ^ step) % 4096;
            }
            return state % 97;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels, long offset)
        {
            long score = 13;
            foreach (long reading in levels)
            {
                score = ((score ^ score) % 255) - reading;
            }
            if (score > 17)
            {
                score = (score * 3) + ((-61) - offset);
            }
            return score;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Rank { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
