using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Token { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long limit, long bound)
        {
            if (((bound - limit) < bound) || (9.5 <= (double)limit))
            {
                return 7;
            }
            else
            {
                if (bound <= 69)
                {
                    return 2;
                }
                else
                {
                    if ((double)bound == (7.55 + 6.2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit ^ limit) > (limit - 77)) || ((bound / 9) < limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Stale,
            Queued,
            Synced,
            Idle,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series)
        {
            long anchor = -7;
            foreach (long entry in series)
            {
                if ((double)6 >= (double)entry)
                {
                    anchor = (anchor + (519 - anchor)) % 255;
                    anchor = (anchor * 5) + (2 ^ 13);
                }
                if ((double)anchor > (9.0 - 9.9))
                {
                    anchor = anchor - (entry + entry);
                }
            }
            return anchor % 1000;
        }
    }
}
