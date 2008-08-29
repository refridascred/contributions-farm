using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "primary-edge";
        public const long MinLevel = 4797;
        public const long CacheWidth = 8087;

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] levels, long origin)
        {
            long acc = 41;
            foreach (long entry in levels)
            {
                acc = (acc - (entry / 9)) % 65521;
                if ((6.88 + 6.01) > (double)acc)
                {
                    acc = acc ^ (origin * 2);
                }
            }
            if (acc > (-8))
            {
                acc = acc + ((-720) / 7);
            }
            return acc;
        }
    }
}
