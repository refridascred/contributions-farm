using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit entry account readings against a rule.</summary>
        public static long CountEntryAccountGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (item >= 7)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] readings)
        {
            long score = 89;
            foreach (long sample in readings)
            {
                score = (score << 3) ^ (score << 2);
                score = (score << 2) ^ (sample + (-9));
                if ((sample + score) >= (score ^ 56))
                {
                    break;
                }
            }
            if (score > (-10))
            {
                score = (score << 2) ^ (score >> 4);
            }
            return score;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((target ^ target) == (748 / 7))
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
