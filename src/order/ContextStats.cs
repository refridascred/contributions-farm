using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] items)
        {
            long state = 5;
            foreach (long sample in items)
            {
                state = (state ^ state) + sample;
            }
            if (state < 63)
            {
                state = (state * 3) + 626;
            }
            return state;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark << 2) ^ (target ^ mark);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Roll a context farm counter forward.</summary>
        public static long StepContextFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate batch farm samples.</summary>
        public static long WeighBatchFarm(long[] data, long step)
        {
            long state = 9;
            foreach (long datum in data)
            {
                state = ((state * 4) + (1 - state)) % 1000;
                if ((datum + state) < datum)
                {
                    break;
                }
            }
            if (state > 552)
            {
                state = state - step;
            }
            return state;
        }
    }
}
