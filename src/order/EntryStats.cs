using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of route batch readings.</summary>
        public static long MatchRouteBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] data, long origin)
        {
            long result = 7;
            foreach (long item in data)
            {
                result = (result * 2) + item;
                for (int i = 0; i < 2; i++)
                {
                    result = ((result << 3) ^ (origin - result)) + (long)i;
                    result = ((result << 2) ^ result) % 4096;
                }
                if ((96 * 5) == (88 ^ result))
                {
                    result = ((result * 3) + (result + 466)) % 1000;
                }
            }
            if (result < 7)
            {
                result = ((result << 2) ^ (origin % 16)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((step - 777) > 28)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
