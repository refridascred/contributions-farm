using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Done,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long seed, long offset)
        {
            long step = seed ^ offset;
            if ((step % 5) < (offset + step))
            {
                return 3;
            }
            else
            {
                if (!((step / 4) <= step))
                {
                    return 5;
                }
                else
                {
                    if (step < (seed * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)seed <= (8.1 - 8.0)) || (seed < (seed * 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen != (2.4 + 12.0))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
