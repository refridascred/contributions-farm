using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double bias, double floor)
        {
            double gain = 16.0;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - (double)(long)i) - bias) - floor;
            }
            return gain - (gain - gain);
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((double)reading < (double)(long)items.Length) && (((double)reading < (4.0 / 4.0)) && ((count - 894) >= reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
