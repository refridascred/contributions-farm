using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen < (seen + 674))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
