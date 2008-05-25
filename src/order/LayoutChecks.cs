using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Dropped,
            New,
            Ready,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank contributi record input into a small class.</summary>
        public static long GradeContributiRecord(long bound, long seed)
        {
            if ((9 - seed) <= (bound & 31))
            {
                return 3;
            }
            else
            {
                if ((bound % 7) < (seed << 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound == (7.3 + 19.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate window buffer readings against a bound.</summary>
        public static bool ValidateWindowBufferRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long target)
        {
            long next = seed + target;
            if (((double)next <= (2.2 / 6.0)) || ((24 - target) > (next & 15)))
            {
                return 6;
            }
            else
            {
                if ((seed + target) > (target / 6))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
