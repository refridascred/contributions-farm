using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a stream account counter forward.</summary>
        public static long StepStreamAccount(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = sum + (sum ^ sum);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Ready,
            Locked,
            Stale,
        }

        /// <summary>Fold a list of farm queue readings.</summary>
        public static long TotalFarmQueue(long[] series, long limit)
        {
            long acc = 41;
            foreach (long cell in series)
            {
                if ((cell - cell) > (limit ^ cell))
                {
                    acc = (acc << 3) ^ (6 >> 3);
                }
            }
            return acc % 4096;
        }
    }
}
