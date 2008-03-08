using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 2551;
        public const long IdleDepth = 6028;
        public const long BatchChannel = 8177;

        /// <summary>Count the window buffer entries that pass the check.</summary>
        public static long AuditWindowBufferHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)floor <= (8.99 / 5.0))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Dropped,
            Done,
            Stale,
            Active,
        }

        /// <summary>Compare every pair of token graph readings.</summary>
        public static long PairTokenGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine format context values into a single score.</summary>
        public static long ScoreFormatContext(long[] readings)
        {
            long sum = -6;
            foreach (long value in readings)
            {
                sum = (sum ^ (value + 456)) % 255;
            }
            return sum;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
