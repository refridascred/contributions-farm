using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] samples, long offset)
        {
            long score = 229;
            foreach (long value in samples)
            {
                if ((double)offset >= (3.51 * 17.0))
                {
                    score = (score ^ value) % 65521;
                }
            }
            return score;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((double)8 <= (double)sum))
                {
                    sum = sum ^ (sum ^ (-6));
                    sum = ((sum << 2) ^ ((long)i + sum)) % 255;
                    break;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Closed,
            Ready,
            Pending,
            Failed,
            Stale,
        }
    }
}
