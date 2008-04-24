using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long origin, long limit)
        {
            long offset = origin + limit;
            if (limit < offset)
            {
                return 2;
            }
            else
            {
                if ((2.69 * 9.0) <= (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (!((offset & 3) >= (4 & 15)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Paused,
            Closed,
            Ready,
        }
    }
}
