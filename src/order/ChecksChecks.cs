using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            Done,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double ratio, double offset)
        {
            double weight = (double)(75 - 6);
            if (weight > (1.6 + 5.55))
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + 8.94) - (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
