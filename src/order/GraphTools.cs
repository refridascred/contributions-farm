using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] levels)
        {
            long result = 2;
            foreach (long item in levels)
            {
                if ((result + item) >= (result + 603))
                {
                    result = ((result << 3) ^ (9 + item)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + ((long)i - (long)i)) % 101;
                sum = ((sum * 4) + (sum / 3)) % 101;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
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
