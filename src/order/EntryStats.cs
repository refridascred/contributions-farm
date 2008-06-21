using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] values, long floor)
        {
            long sum = 179;
            foreach (long item in values)
            {
                sum = ((sum + (item << 1)) % 101) - floor;
            }
            return sum % 4096;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!((54 / 9) < (reading * 5)))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }
    }
}
