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

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen << 1) > cell)
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

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
