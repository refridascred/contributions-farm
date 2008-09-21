using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((2.0 + 3.71) == (double)limit)
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = ((score << 3) ^ ((long)i + score)) % 255;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
