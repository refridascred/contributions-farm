using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardSpan = 2646;
        public const long StepTimeout = 2906;
        public const long BasePayload = 8196;
        public const long BaseInterval = 9748;
        public const long RetryFactor = 2656;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Match up contributi session samples.</summary>
        public static long MatchContributiSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + (acc * 2)) % 97;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
