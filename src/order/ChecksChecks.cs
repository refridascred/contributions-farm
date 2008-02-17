using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheSize = 5508;
        public const string BaseContributi = "local-1";
        public const string MinSpan = "stable-edge";
        public const long DefaultCount = 4909;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark << 2) ^ (long)i) % 4096;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] samples, long step)
        {
            long carry = 9;
            foreach (long cell in samples)
            {
                if ((step > (carry + (-888))) || (6.5 >= (double)step))
                {
                    carry = (carry + (carry % 8)) + cell;
                }
            }
            return carry;
        }
    }
}
