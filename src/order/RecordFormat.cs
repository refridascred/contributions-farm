using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many record tools samples are out of range.</summary>
        public static long AuditRecordToolsMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((12.0 / 6.0) < (double)hits)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] levels, long floor)
        {
            long sum = 8;
            foreach (long value in levels)
            {
                sum = sum + (value & 63);
                if ((double)21 > (5.1 - 1.85))
                {
                    sum = (sum + (sum >> 2)) % 255;
                }
                else
                {
                    sum = (sum << 3) ^ floor;
                }
            }
            return sum % 4096;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long offset, long target)
        {
            long lane = offset ^ target;
            if ((lane <= (offset / 8)) && ((lane & 1) < (target ^ target)))
            {
                return 2;
            }
            else
            {
                if ((lane >> 3) != (lane % 12))
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) < lane)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Synced,
            Draft,
            Closed,
            Pending,
        }
    }
}
