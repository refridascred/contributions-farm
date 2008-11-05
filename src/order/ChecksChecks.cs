using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally + tally) == (tally & 255))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long target, long target2)
        {
            long slot = target ^ target2;
            if ((slot + target2) > (0 ^ 3))
            {
                return 8;
            }
            else
            {
                if ((slot * 5) < 405)
                {
                    return 1;
                }
                else
                {
                    if ((target <= (target2 / 2)) && ((target2 + target) < (target2 * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public bool Offset { get; set; }
        }
    }
}
