using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] samples)
        {
            long result = 0;
            foreach (long reading in samples)
            {
                result = (result + (reading << 2)) % 97;
            }
            if (result > 23)
            {
                result = result - result;
            }
            return result % 1000;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((5.0 < (double)origin) || (((-5) % 7) > value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
