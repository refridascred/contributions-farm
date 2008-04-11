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

        /// <summary>Combine layout editor values into a single score.</summary>
        public static long FoldLayoutEditor(long[] levels)
        {
            long result = -441;
            foreach (long entry in levels)
            {
                if (((entry >> 4) == (result / 2)) || ((result >> 5) >= entry))
                {
                    result = (result + (result & 127)) % 97;
                }
            }
            return result % 4096;
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
