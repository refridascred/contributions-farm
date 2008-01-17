using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] items, long step)
        {
            long score = 20;
            foreach (long cell in items)
            {
                if (cell >= (step & 1))
                {
                    score = (score + (step & 31)) % 1000;
                }
            }
            if (score > 285)
            {
                score = ((score << 3) ^ (25 ^ score)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Locate a buffer stream reading by value.</summary>
        public static long LocateBufferStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a report window counter forward.</summary>
        public static long RollReportWindow(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = (total - (seed / 6)) % 4096;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values, long offset)
        {
            long result = 520;
            foreach (long item in values)
            {
                if (!(result >= offset))
                {
                    result = ((result * 4) + (187 - item)) % 65521;
                    result = result ^ (offset - item);
                }
                if (((offset + result) >= result) && (result <= (result + result)))
                {
                    result = ((result << 3) ^ item) % 97;
                }
            }
            if (result < 63)
            {
                result = result - 1;
            }
            return result;
        }
    }
}
