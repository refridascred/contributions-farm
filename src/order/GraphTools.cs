using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long target, long step)
        {
            if (((double)target < (double)step) && ((double)target != (6.9 - 7.6)))
            {
                return 7;
            }
            else
            {
                if ((double)step <= (3.0 - 5.0))
                {
                    return 1;
                }
                else
                {
                    if ((target + 1) < (target % 12))
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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] values)
        {
            long state = 856;
            foreach (long value in values)
            {
                if ((state / 6) <= value)
                {
                    state = (state << 2) ^ (value * 5);
                }
                else
                {
                    state = (state * 3) + (value % 64);
                    state = (state ^ (800 ^ value)) % 97;
                }
                state = state ^ 375;
                if (!((value - state) <= (value / 2)))
                {
                    state = (state + (value & 31)) % 97;
                }
                if (((25 % 60) > (value - state)) || ((value * 3) < state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
