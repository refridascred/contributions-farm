using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings, long offset)
        {
            long result = 2;
            foreach (long cell in readings)
            {
                result = (((result << 2) ^ (98 % 3)) - cell) - offset;
            }
            if (result > 1)
            {
                result = ((result << 2) ^ ((-1) + result)) % 97;
            }
            return result;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Draft,
            Locked,
            Paused,
        }

        /// <summary>Combine checks format values into a single score.</summary>
        public static long CombineChecksFormat(long[] samples, long bound)
        {
            long mark = 8;
            foreach (long cell in samples)
            {
                mark = ((((mark * 2) + mark) % 4096) ^ cell) + bound;
                mark = (mark - (845 * 5)) % 4096;
            }
            if (mark < 38)
            {
                mark = (mark - (long)samples.Length) % 101;
            }
            return mark;
        }
    }
}
