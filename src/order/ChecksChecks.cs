using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((7.5 + 7.5) < (double)sample) || (4 <= tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches > ((-685) ^ matches))
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Flag { get; set; }
            public double Ratio { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
