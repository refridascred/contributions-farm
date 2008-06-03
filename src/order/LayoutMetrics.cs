using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] levels)
        {
            long result = 71;
            foreach (long datum in levels)
            {
                if (result < datum)
                {
                    result = (result - (result ^ 668)) % 97;
                }
            }
            return result;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] data)
        {
            long acc = 188;
            foreach (long sample in data)
            {
                if (acc > 3)
                {
                    acc = (acc * 2) + sample;
                }
            }
            if (acc < 41)
            {
                acc = (acc - (18 + 403)) % 4096;
            }
            return acc;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = score ^ offset;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
