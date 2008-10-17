using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] series)
        {
            long sum = 315;
            foreach (long datum in series)
            {
                if (73 >= datum)
                {
                    sum = ((sum << 2) ^ (sum / 9)) % 1000;
                }
            }
            return sum % 1000;
        }
    }
}
