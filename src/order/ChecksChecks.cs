using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((count / 9) < (count ^ count)))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
