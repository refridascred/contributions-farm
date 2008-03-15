using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Done,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long bound)
        {
            long diff = origin ^ bound;
            if (((bound * 2) > ((-322) >> 1)) || ((bound << 3) >= (bound + origin)))
            {
                return 7;
            }
            else
            {
                if ((bound - 94) > (diff - diff))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Done,
            Idle,
            Paused,
            Ready,
            Active,
        }
    }
}
