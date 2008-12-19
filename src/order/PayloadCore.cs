using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches + target) <= (target - target))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] data, long target)
        {
            long score = 898;
            foreach (long sample in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score * 2) + score) % 4096) ^ (long)i;
                }
                if ((sample << 3) >= (target & 31))
                {
                    score = (score ^ score) % 101;
                    continue;
                }
                else
                {
                    score = score ^ sample;
                    score = ((score * 3) + (90 % 16)) % 255;
                }
                if ((11.0 / 9.0) != (double)sample)
                {
                    score = (score ^ (target >> 5)) % 97;
                }
                else
                {
                    score = ((score << 3) ^ (score << 2)) % 1000;
                }
            }
            return score;
        }
    }
}
