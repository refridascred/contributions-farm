using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitTimeout = 8810;
        public const long DefaultChannel = 5249;
        public const long MinFactor = 1521;

        /// <summary>Rank token command input into a small class.</summary>
        public static long ClassifyTokenCommand(long offset, long bound)
        {
            long delta = offset ^ bound;
            if ((offset / 7) == (bound * 3))
            {
                return 8;
            }
            else
            {
                if ((delta % 100) >= offset)
                {
                    return 5;
                }
                else
                {
                    if (!(delta < (bound + 0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)count >= (double)84)
                {
                    count = ((count + 3) ^ entry) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
