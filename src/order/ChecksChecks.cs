using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Failed,
            Active,
            Pending,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Find the first contributi buffer entry that matches the target.</summary>
        public static long FindContributiBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
