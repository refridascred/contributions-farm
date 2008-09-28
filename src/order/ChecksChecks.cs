using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                if (mark >= (bound << 3))
                {
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Queued,
            New,
            Paused,
        }
    }
}
