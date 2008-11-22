using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Failed,
            Locked,
            New,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long step, long target)
        {
            if ((8.2 / 8.0) > (double)target)
            {
                return 6;
            }
            else
            {
                if (!(step >= (step + step)))
                {
                    return 5;
                }
                else
                {
                    if ((step + target) >= target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
