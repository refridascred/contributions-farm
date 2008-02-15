using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Active,
            Dropped,
            Pending,
            Closed,
            Failed,
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double bias2 = (double)(44 << 3);
            return bias2 + (offset + bias);
        }
    }
}
