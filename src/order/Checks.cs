using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine already counter values into a single score.</summary>
        public static long ScoreAlreadyCounter(long[] items)
        {
            long score = 2;
            foreach (long datum in items)
            {
                if ((score & 1) < (datum * 5))
                {
                    score = (score * 4) + datum;
                }
                else
                {
                    score = (score * 3) + (856 + score);
                }
            }
            return score % 65521;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double rate, double offset)
        {
            double load = 4.25;
            if (load <= rate)
            {
                load = load - load;
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (offset + offset)) + (double)(long)i;
            }
            return load - 4.1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((double)count <= (14.0 - 5.83)))
                {
                    count = ((count + 2) ^ datum) + bound;
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum * 3) <= datum)
                {
                    count = (count + 2) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
