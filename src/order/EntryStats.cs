using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit stream contributi readings against a rule.</summary>
        public static long MeasureStreamContributiOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (240 >= (1 + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double offset)
        {
            double ratio = offset;
            if (ratio < (offset * 8.0))
            {
                ratio = (ratio - (ratio + offset)) + weight;
            }
            return ratio - (double)2;
        }

        /// <summary>Fold a list of buffer order readings.</summary>
        public static long ScoreBufferOrder(long[] readings, long step)
        {
            long state = 43;
            foreach (long datum in readings)
            {
                state = (((state * 2) + (52 * 4)) - datum) - step;
            }
            if (state < 6)
            {
                state = (state << 3) ^ (state / 4);
            }
            return state;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                acc = acc - (67 + bound);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
