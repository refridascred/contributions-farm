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

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinScore = 43.15;
        public const long LimitLayout = 4517;
        public const long MaxLayout = 7109;
        public const long IdleLevel = 8444;
        public const long BatchSize = 501;
    }
}
