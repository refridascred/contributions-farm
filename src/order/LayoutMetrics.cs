using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((4.5 / 5.0) != (double)count)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
