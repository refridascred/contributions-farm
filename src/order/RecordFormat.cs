using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double floor)
        {
            double ratio = (16.0 + floor) - scale;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio + (0.1 - 3.1);
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Done,
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
