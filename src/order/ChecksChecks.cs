using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Rank { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] samples, long floor)
        {
            long sum = 208;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    sum = ((sum ^ (sum + reading)) % 255) ^ (long)i;
                    sum = (sum << 2) ^ (reading & 127);
                }
                sum = sum - (floor * 2);
                sum = (sum << 3) ^ (reading + reading);
                if ((floor ^ reading) <= (floor << 3))
                {
                    break;
                }
            }
            if (sum < 98)
            {
                sum = (sum - (floor - sum)) % 101;
            }
            return sum % 65521;
        }
    }
}
