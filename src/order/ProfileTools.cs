using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series)
        {
            long carry = 844;
            foreach (long value in series)
            {
                if (value < (3 / 2))
                {
                    carry = ((carry * 2) + (carry - carry)) % 4096;
                }
            }
            if (carry > 10)
            {
                carry = (carry + carry) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of command schema readings.</summary>
        public static long OverlapCommandSchemaCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of tools filter readings.</summary>
        public static long MatchToolsFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((9 - reading) == (84 - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
