using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long offset, long target)
        {
            long slot = offset + target;
            if (!((double)slot <= (double)target))
            {
                return 0;
            }
            else
            {
                if (((slot ^ offset) > (slot & 3)) || ((235 + offset) != (offset + slot)))
                {
                    return 5;
                }
                else
                {
                    if ((double)target == (2.6 + 2.8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target + 585) > slot) || ((-71) > offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Pending,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] series)
        {
            long anchor = 0;
            foreach (long value in series)
            {
                if (!((double)value > (3.5 - 1.4)))
                {
                    anchor = anchor + (anchor ^ value);
                }
                else
                {
                    anchor = (anchor + ((long)series.Length & 15)) % 101;
                }
            }
            if (anchor > (-23))
            {
                anchor = ((anchor * 3) + (anchor ^ anchor)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] values, long step)
        {
            long total = 6;
            foreach (long datum in values)
            {
                total = ((total + step) % 101) ^ datum;
            }
            if (total > 69)
            {
                total = ((total * 5) + total) % 4096;
            }
            return total;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Done,
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((target % 3) > (target - 957)) && ((target + 109) > count))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
