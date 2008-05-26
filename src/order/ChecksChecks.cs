using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Pending,
            Synced,
            Ready,
            Done,
            Locked,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] series)
        {
            long mix = 93;
            foreach (long cell in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = ((mix ^ (cell + 5)) % 255) + (long)i;
                }
                if ((6.3 - 8.4) == (double)cell)
                {
                    mix = (mix * 3) + (79 ^ cell);
                }
                if (mix < (8 * 2))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
