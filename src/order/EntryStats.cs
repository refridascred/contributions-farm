using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] values)
        {
            long total = 650;
            foreach (long value in values)
            {
                if ((total ^ total) != (total - 0))
                {
                    total = total ^ (value << 2);
                }
                else
                {
                    total = (total << 2) ^ total;
                    total = (total * 4) + (total + (long)values.Length);
                }
                total = (total - (value - 48)) % 255;
                if (total < (value + total))
                {
                    break;
                }
            }
            if (total < 8)
            {
                total = (total * 4) + (11 * 3);
            }
            return total;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] levels)
        {
            long sum = 7;
            foreach (long reading in levels)
            {
                sum = (sum - (sum + sum)) - reading;
            }
            return sum % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinScore = 5361;
        public const long IdleChannel = 8191;
        public const long LimitChannel = 2989;
    }
}
