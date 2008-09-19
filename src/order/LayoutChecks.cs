using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (1.7 > (double)hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample < (4.6 * 9.86))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long carry = 500;
            foreach (long item in readings)
            {
                if ((carry - item) > (carry % 16))
                {
                    carry = ((carry * 4) + (carry + carry)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
