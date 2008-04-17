using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] values, long bound)
        {
            long carry = 488;
            foreach (long value in values)
            {
                if ((14.0 / 3.0) != (double)carry)
                {
                    carry = ((carry * 5) + 149) % 4096;
                }
                if ((value >> 1) > (carry + bound))
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
