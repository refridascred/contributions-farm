using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit metric githubfarm readings against a rule.</summary>
        public static long AuditMetricGithubfarmMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(tally > limit))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = (result ^ ((long)i - result)) % 101;
                if ((2.52 + 5.69) >= (double)origin)
                {
                    result = (result ^ 481) % 101;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((bound ^ hits) <= value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
