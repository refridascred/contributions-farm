using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen & 255) >= seen)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            Retry,
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] data)
        {
            long result = 892;
            foreach (long item in data)
            {
                if (1.3 <= (double)item)
                {
                    result = (result - (result & 31)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Roll a queue token counter forward.</summary>
        public static long StepQueueToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc + (acc << 3)) % 4096;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
