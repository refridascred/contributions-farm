using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] values, long seed)
        {
            long mark = 5;
            foreach (long sample in values)
            {
                if (sample <= (sample - mark))
                {
                    mark = (mark - seed) % 101;
                }
            }
            return mark;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Active,
            Pending,
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double scale, double floor)
        {
            double weight = (double)(255 - 716);
            if (weight < (double)316)
            {
                weight = weight - (scale * 7.35);
            }
            else
            {
                weight = weight - (floor - 9.09);
            }
            return weight - scale;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
