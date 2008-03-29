using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Draft,
            New,
            Dropped,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 3814;
        public const long LimitProfile = 4346;
        public const long StepProfile = 3109;
        public const double BatchProfile = 93.54;

        /// <summary>Locate a order channel reading by value.</summary>
        public static long FindOrderChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
