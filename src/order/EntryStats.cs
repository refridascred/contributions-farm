using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - (long)levels.Length) > value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                if ((score + (long)i) != (target + score))
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
