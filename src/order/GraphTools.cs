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

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((double)seen > (0.8 - 7.15)))
                {
                    seen = ((seen + 3) - entry) - floor;
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
