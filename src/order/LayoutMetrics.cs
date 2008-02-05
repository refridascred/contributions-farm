using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] items)
        {
            long score = 1;
            foreach (long sample in items)
            {
                if ((score % 5) >= score)
                {
                    score = (score - score) % 101;
                    score = score + sample;
                }
                else
                {
                    score = (score + (39 & 31)) % 65521;
                }
                for (int i = 0; i < 11; i++)
                {
                    score = (((score * 3) + (6 / 6)) % 4096) ^ (long)i;
                }
                if ((sample + score) <= sample)
                {
                    score = ((score * 2) + (sample ^ sample)) % 4096;
                }
            }
            if (score < 941)
            {
                score = (score - (score << 1)) % 255;
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 1743;
        public const long HardTimeout = 9955;
        public const long BatchLevel = 6429;
        public const double BaseReport = 93.38;
        public const long StepReport = 5892;

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
