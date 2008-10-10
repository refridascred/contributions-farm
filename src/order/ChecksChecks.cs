using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] levels, long target)
        {
            long carry = 630;
            foreach (long reading in levels)
            {
                if ((4.09 + 20.0) >= (double)reading)
                {
                    carry = ((carry * 4) + carry) - target;
                }
            }
            if (carry > 584)
            {
                carry = carry - carry;
            }
            return carry % 97;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
