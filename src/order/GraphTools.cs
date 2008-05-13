using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item + matches) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSpan = 8762;
        public const long SoftAlready = 3440;
        public const long MinAlready = 439;
        public const long HardLevel = 8407;

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] readings)
        {
            long anchor = 7;
            foreach (long cell in readings)
            {
                anchor = (anchor ^ (cell + anchor)) % 1000;
            }
            if (anchor < 2)
            {
                anchor = (anchor + (anchor >> 4)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Mode { get; set; }
            public string Level { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
