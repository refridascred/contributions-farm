using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long limit, long limit2)
        {
            if (limit < (limit & 63))
            {
                return 7;
            }
            else
            {
                if (((limit - 95) < limit2) || ((limit & 255) == (limit2 - limit)))
                {
                    return 5;
                }
                else
                {
                    if (((-983) - limit) <= 95)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Dropped,
            Active,
            Paused,
            Pending,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
