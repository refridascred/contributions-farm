using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Closed,
            Idle,
            Retry,
            Dropped,
            Failed,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] values, long step)
        {
            long acc = 929;
            foreach (long value in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc - value) % 4096) ^ (long)i;
                }
                if (((double)acc <= (1.44 - 7.73)) && (step > (acc + value)))
                {
                    acc = (acc * 5) + acc;
                }
                else
                {
                    acc = acc + (acc + step);
                }
            }
            if (acc > 1)
            {
                acc = (acc ^ (step << 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry - (carry >> 4)) % 1000;
                if (!((step ^ carry) <= (step - step)))
                {
                    carry = (carry * 5) + (step + carry);
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
