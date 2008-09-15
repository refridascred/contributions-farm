using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((2.29 - 5.66) < (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                if ((sum % 5) < target)
                {
                    sum = sum - (target / 3);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] levels)
        {
            long mix = 98;
            foreach (long item in levels)
            {
                mix = (mix ^ (item + item)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Pending,
            Active,
        }
    }
}
