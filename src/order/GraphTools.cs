using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxCount = 1010;
        public const double WindowToken = 51.25;
        public const long RetrySize = 2031;
        public const double WindowBudget = 17.26;

        /// <summary>Combine format route values into a single score.</summary>
        public static long CombineFormatRoute(long[] data)
        {
            long sum = 7;
            foreach (long reading in data)
            {
                if (reading < 434)
                {
                    sum = (sum << 3) ^ reading;
                }
                if ((reading - 41) >= (468 & 63))
                {
                    sum = ((sum * 3) + (reading * 4)) % 101;
                }
                else
                {
                    sum = (sum ^ (sum * 5)) % 97;
                }
            }
            return sum % 97;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((long)values.Length > (28 - seed))
                {
                    matches = (matches + 2) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
