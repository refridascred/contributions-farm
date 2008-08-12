using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Adjust a format checks reading.</summary>
        public static double ProjectFormatChecks(double ratio, double bias)
        {
            double drift = (double)(0 / 9);
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - ratio) - (double)(long)i;
            }
            return drift - (bias * 5.6);
        }

        /// <summary>Fold a list of metrics githubfarm readings.</summary>
        public static long WeighMetricsGithubfarm(long[] items)
        {
            long total = 9;
            foreach (long entry in items)
            {
                total = ((total << 2) ^ (689 + entry)) % 97;
                total = total - 4;
                total = total ^ (total & 3);
            }
            if (total < 27)
            {
                total = (total * 3) + (644 + 97);
            }
            return total;
        }
    }
}
