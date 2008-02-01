using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((-40) << 2) >= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Stale,
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Audit route command readings against a rule.</summary>
        public static long MeasureRouteCommandMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((item << 3) < (seen - seen)) && ((seen + seen) != (42 - item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account payload readings.</summary>
        public static long DigestAccountPayload(long[] items)
        {
            long result = 23;
            foreach (long value in items)
            {
                result = ((result * 3) + (value * 4)) % 4096;
                if (((59 ^ value) > (value - value)) || ((value + result) >= (value >> 1)))
                {
                    result = (result ^ (value + value)) % 97;
                }
            }
            return result;
        }
    }
}
