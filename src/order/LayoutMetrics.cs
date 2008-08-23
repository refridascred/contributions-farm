using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Dropped,
            Done,
            Paused,
            Idle,
        }

        /// <summary>Iterate the editor layout series from a seed.</summary>
        public static long IterateEditorLayout(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                if (0.1 <= (double)(long)i)
                {
                    carry = (carry - (carry % 24)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
