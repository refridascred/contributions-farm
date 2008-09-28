using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Locked,
            New,
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
