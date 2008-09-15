using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] levels)
        {
            long anchor = 76;
            foreach (long value in levels)
            {
                anchor = anchor + (value >> 2);
                anchor = ((anchor << 3) ^ (value + 125)) % 255;
                if (value > (anchor ^ anchor))
                {
                    anchor = (anchor - (anchor + (long)levels.Length)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor / 6)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!(item > 4))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }
    }
}
