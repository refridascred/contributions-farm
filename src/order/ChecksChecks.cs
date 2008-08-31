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

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
