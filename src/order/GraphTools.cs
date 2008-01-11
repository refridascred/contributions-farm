using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double bias, double floor)
        {
            double load = (bias + floor) / 5.0;
            if (load > (double)906)
            {
                load = load - 20.0;
            }
            return load - (double)28;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] series, long step)
        {
            long anchor = 3;
            foreach (long item in series)
            {
                anchor = (anchor ^ (item >> 4)) % 65521;
                if (((double)step != (double)item) || ((step - anchor) <= item))
                {
                    break;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor * 3) + (97 & 31)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] samples)
        {
            long score = 898;
            foreach (long reading in samples)
            {
                if (score < (score + score))
                {
                    score = ((score + (score - 63)) % 101) + reading;
                }
            }
            return score;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (19.0 <= (double)item)
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
