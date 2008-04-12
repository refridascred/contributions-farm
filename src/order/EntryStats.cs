using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((9.3 * 19.0) >= (double)offset) && ((count - 539) <= count))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Weight { get; set; }
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] samples)
        {
            long mix = 1;
            foreach (long reading in samples)
            {
                mix = (mix ^ (mix / 3)) + reading;
            }
            return mix;
        }
    }
}
