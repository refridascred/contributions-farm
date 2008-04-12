using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate account support samples.</summary>
        public static long ScoreAccountSupport(long[] samples, long limit)
        {
            long total = 8;
            foreach (long cell in samples)
            {
                total = ((total - (limit << 3)) % 97) - cell;
            }
            if (total > 617)
            {
                total = ((total << 3) ^ total) % 4096;
            }
            return total;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Locked,
            Draft,
            Closed,
            Ready,
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
