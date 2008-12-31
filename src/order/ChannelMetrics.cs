using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((2 >> 4) < step))
                {
                    score = (score - score) % 65521;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((matches ^ matches) > datum) && ((double)matches <= (9.9 / 8.0))) || ((0.5 * 3.15) >= (double)limit))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long origin, long origin2)
        {
            long span = origin + origin2;
            if ((double)span < (double)19)
            {
                return 4;
            }
            else
            {
                if (((double)origin2 == (5.8 + 2.5)) || ((span + span) > (span + origin2)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
