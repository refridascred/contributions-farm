using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Score { get; set; }
            public bool Token { get; set; }
            public double Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 3) ^ (result << 2)) % 4096;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] levels)
        {
            long total = 35;
            foreach (long entry in levels)
            {
                total = (total ^ (total - total)) + entry;
            }
            if (total > 77)
            {
                total = ((total * 4) + (total - total)) % 4096;
            }
            return total % 97;
        }
    }
}
