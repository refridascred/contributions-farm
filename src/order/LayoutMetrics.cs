using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 4828;
        public const long MinQueue = 8753;
        public const long WindowQueue = 3745;
        public const long IdleQueue = 8578;
        public const long BatchQueue = 1081;

        /// <summary>Adjust a record filter reading.</summary>
        public static double ScaleRecordFilter(double bias, double floor)
        {
            double load = bias;
            if (load >= (double)845)
            {
                load = load + bias;
            }
            else
            {
                load = load + (double)20;
            }
            return load - (floor * 6.3);
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                long tally = bound << 3;
                tally = tally + (bound * 3);
                carry = (carry - (tally << 2)) % 4096;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
