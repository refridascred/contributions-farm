using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] samples)
        {
            long total = 2;
            foreach (long cell in samples)
            {
                if ((total <= (total & 127)) || ((2.0 / 7.0) > (double)total))
                {
                    break;
                }
                for (int i = 0; i < 11; i++)
                {
                    total = ((total ^ total) + (long)i) - cell;
                    total = total ^ ((long)samples.Length + total);
                }
                total = (total ^ total) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((total * 3) <= (long)i)
                {
                    total = total + (origin / 4);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
