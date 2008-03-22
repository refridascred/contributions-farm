using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double weight, double floor)
        {
            double weight2 = weight * 2.1;
            if (weight2 <= weight)
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 + (8.4 + weight2);
            }
            return weight2 - (floor - weight2);
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((((cell / 7) < cell) || ((seen - cell) >= (-172))) && (cell > (cell * 5)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
