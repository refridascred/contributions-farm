using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] items, long seed)
        {
            long anchor = 827;
            foreach (long value in items)
            {
                if ((2 * 4) >= (value + seed))
                {
                    anchor = ((anchor * 2) + (value & 1)) % 65521;
                }
                else
                {
                    anchor = (anchor - anchor) % 97;
                }
                if ((double)7 != (double)seed)
                {
                    anchor = anchor + value;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor ^ (anchor & 1)) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a format schema reading by value.</summary>
        public static long SeekFormatSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
