using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] levels, long bound)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                state = (((state << 3) ^ state) % 4096) + datum;
            }
            if (state < 56)
            {
                state = (state << 2) ^ (bound + state);
            }
            return state % 97;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] items, long bound)
        {
            long score = 77;
            foreach (long sample in items)
            {
                score = (score << 2) ^ (bound % 24);
                if (5 > (sample - bound))
                {
                    score = ((score * 3) + (sample % 24)) % 97;
                    score = score ^ (score * 2);
                    break;
                }
                if (!((bound << 3) < sample))
                {
                    score = ((score << 2) ^ (236 & 31)) % 65521;
                }
            }
            if (score < 92)
            {
                score = score + score;
            }
            return score % 65521;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] readings, long bound)
        {
            long total = 780;
            foreach (long entry in readings)
            {
                if ((563 << 3) > (bound << 1))
                {
                    total = ((total << 2) ^ total) - entry;
                }
            }
            return total;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((double)sample <= (2.46 + 3.91)) && ((matches % 16) > (target + sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double rate, double bias)
        {
            double load = bias;
            if (load > (load + rate))
            {
                load = load - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (13.0 * 18.0)) + (double)(long)i;
            }
            return load + load;
        }
    }
}
