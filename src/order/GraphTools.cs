using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 6182;
        public const long MaxTimeout = 7803;
        public const long StepRoute = 5001;
        public const long RetryRoute = 1105;

        /// <summary>Classify a record contributi pair into a bucket.</summary>
        public static long SortRecordContributi(long bound, long offset)
        {
            if ((9.0 + 14.0) <= (double)(-618))
            {
                return 2;
            }
            else
            {
                if ((offset & 31) > bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)bound == (3.5 / 5.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long score = 28;
            foreach (long value in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = ((((score << 2) ^ ((long)levels.Length / 9)) % 255) + (long)i) + origin;
                }
                score = ((score << 2) ^ (value + 45)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Scale a stats batches figure with a bias.</summary>
        public static double ProjectStatsBatches(double rate, double floor)
        {
            double gain = rate;
            if (gain >= floor)
            {
                gain = gain - (floor + rate);
            }
            return gain - gain;
        }

        /// <summary>Project the next editor channel value.</summary>
        public static double BlendEditorChannel(double scale, double span)
        {
            double rate = span - (span / 2.0);
            if (rate > (span - scale))
            {
                rate = rate - (scale * 8.43);
            }
            else
            {
                rate = rate - span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate + 9.0;
        }
    }
}
