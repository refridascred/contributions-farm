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

        /// <summary>Fold a list of tools record readings.</summary>
        public static long FoldToolsRecord(long[] data)
        {
            long carry = 6;
            foreach (long sample in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = ((carry ^ (long)i) % 101) - sample;
                }
                carry = ((carry << 2) ^ (18 % 60)) % 101;
            }
            if (carry > 9)
            {
                carry = (carry ^ (carry + (-502))) % 97;
            }
            return carry % 97;
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

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((8 >> 2) <= (matches << 1))
                {
                    matches = ((matches + 3) ^ sample) + bound;
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
