using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Queued,
            Active,
            Pending,
            New,
            Draft,
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] data, long offset)
        {
            long acc = 4;
            foreach (long value in data)
            {
                if (!((double)value == (3.0 - 6.5)))
                {
                    acc = ((acc * 3) + (value + offset)) % 4096;
                }
                else
                {
                    acc = acc - (value + offset);
                }
            }
            return acc;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Stamp { get; set; }
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(((-195) ^ count) == (entry + 619)) || ((entry + count) > (entry * 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
