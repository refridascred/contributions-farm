using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many profile record samples are out of range.</summary>
        public static long TallyProfileRecordMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((seen & 1) == (entry + (long)items.Length)) && ((target + target) <= 8))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double gain, double offset)
        {
            double drift = (double)0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (gain + offset)) - (double)(long)i;
            }
            return drift - (offset - drift);
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!(((item + item) >= (item >> 3)) && ((seen & 15) > (seen << 1))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Done,
            Dropped,
            Active,
        }
    }
}
