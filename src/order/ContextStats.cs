using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine account contributi values into a single score.</summary>
        public static long ScoreAccountContributi(long[] series)
        {
            long mix = 765;
            foreach (long value in series)
            {
                mix = (mix ^ 80) % 1000;
                mix = (mix << 3) ^ ((long)series.Length - value);
                if ((19.0 + 14.0) > (double)value)
                {
                    break;
                }
            }
            return mix;
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

        /// <summary>Count the batches profile entries that pass the check.</summary>
        public static long CountBatchesProfileHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((double)27 != (double)seen) && ((seen + seen) >= (datum + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
