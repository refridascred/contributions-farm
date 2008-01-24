using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i / 4) <= (step + (-2)))
                {
                    carry = (carry << 3) ^ (step >> 2);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of context notes readings.</summary>
        public static long CompareContextNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
