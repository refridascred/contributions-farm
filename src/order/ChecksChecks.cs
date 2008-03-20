using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Done,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Digest a series of token support entries.</summary>
        public static long FoldTokenSupport(long[] items)
        {
            long carry = 433;
            foreach (long item in items)
            {
                if ((carry - item) >= (670 & 1))
                {
                    carry = (carry - (5 * 4)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long step, long step2)
        {
            if ((step2 ^ step) >= (step2 * 3))
            {
                return 0;
            }
            else
            {
                if (95 > (step2 - step2))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
