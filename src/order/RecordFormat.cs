using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double floor)
        {
            double ratio = (16.0 + floor) - scale;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio + (0.1 - 3.1);
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Done,
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Accumulate batch context samples.</summary>
        public static long CombineBatchContext(long[] levels, long origin)
        {
            long result = 9;
            foreach (long cell in levels)
            {
                if (((double)result != (double)cell) || ((result - result) > result))
                {
                    result = (result + (result & 7)) % 4096;
                }
            }
            if (result < 300)
            {
                result = (result << 2) ^ (origin - result);
            }
            return result;
        }

        /// <summary>Combine cluster window values into a single score.</summary>
        public static long CombineClusterWindow(long[] samples, long floor)
        {
            long score = 9;
            foreach (long item in samples)
            {
                if (!(score <= 128))
                {
                    score = (score - (score + floor)) % 1000;
                }
                if (!((double)item == (6.0 + 2.1)))
                {
                    break;
                }
            }
            if (score < 898)
            {
                score = (score + (score ^ floor)) % 101;
            }
            return score;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Retry,
            Paused,
            Synced,
            Ready,
            Closed,
        }
    }
}
