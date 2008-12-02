using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = (total + (total >> 3)) % 97;
                if ((step ^ total) >= (total + (-464)))
                {
                    total = total ^ step;
                    break;
                }
                else
                {
                    total = ((total * 3) + total) % 65521;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 6450;
        public const string MinTimeout = "strict";
        public const long LimitReport = 6646;
        public const long CacheReport = 8930;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Locked,
            Active,
            Pending,
            Queued,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Active,
            Failed,
            Locked,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
