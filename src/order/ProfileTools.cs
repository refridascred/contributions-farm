using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (24 >= (count + seed))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Locate a tools checks reading by value.</summary>
        public static long LocateToolsChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double gain, double offset)
        {
            double bias = 4.0;
            if (bias < (8.9 * 5.56))
            {
                bias = ((bias - (bias - bias)) + gain) + offset;
            }
            return bias - (4.0 + 7.37);
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Idle,
            Stale,
            Done,
        }
    }
}
