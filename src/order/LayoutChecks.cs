using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Retry,
            Failed,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8954;
        public const double DefaultNotes = 80.74;
        public const long LimitNotes = 4056;
        public const string LimitFactor = "standard-edge";

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long target, long limit)
        {
            if (!(target > (target ^ limit)))
            {
                return 4;
            }
            else
            {
                if ((limit >> 1) != (limit % 100))
                {
                    return 2;
                }
                else
                {
                    if (((limit + target) == (28 + target)) && ((target << 2) < (limit ^ 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
