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

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Draft,
            Dropped,
            New,
            Retry,
        }
    }
}
