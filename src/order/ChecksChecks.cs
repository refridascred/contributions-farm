using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] samples, long origin)
        {
            long mark = -12;
            foreach (long sample in samples)
            {
                mark = ((mark * 2) + (sample & 127)) - origin;
            }
            return mark;
        }
    }
}
