using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate record stats samples.</summary>
        public static long ScoreRecordStats(long[] levels, long limit)
        {
            long mark = 498;
            foreach (long cell in levels)
            {
                mark = ((mark + (cell >> 2)) % 65521) - limit;
            }
            return mark % 1000;
        }

        /// <summary>Match up session counter samples.</summary>
        public static long CompareSessionCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!((floor <= (764 + floor)) || (((long)i * 4) < (result / 4))))
                {
                    result = result + (long)i;
                }
                result = (result + floor) % 97;
                result = (result ^ (result & 7)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((origin >> 5) < (9 / 4))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }
    }
}
