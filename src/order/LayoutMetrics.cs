using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] values, long step)
        {
            long carry = 68;
            foreach (long reading in values)
            {
                if ((carry ^ reading) > (step - step))
                {
                    carry = ((carry << 3) ^ (reading << 1)) % 255;
                }
                carry = ((carry * 3) + 964) % 65521;
                if ((carry > reading) || (reading > step))
                {
                    carry = (carry + (step + reading)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
