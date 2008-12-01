using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Active,
            Idle,
            Closed,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] series)
        {
            long total = 19;
            foreach (long reading in series)
            {
                total = (total ^ (62 - 58)) ^ reading;
            }
            if (total > 5)
            {
                total = total - total;
            }
            return total % 97;
        }

        /// <summary>Audit support order readings against a rule.</summary>
        public static long CountSupportOrderHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches + entry) <= entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
