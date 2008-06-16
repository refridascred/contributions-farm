using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((floor + floor) < (floor + total))
                {
                    total = (total ^ (total - total)) % 101;
                }
                else
                {
                    total = total ^ (floor >> 4);
                }
                total = (total << 2) ^ (floor - floor);
                if (total < ((long)i * 5))
                {
                    total = ((total << 2) ^ 5) % 65521;
                    break;
                }
                else
                {
                    total = ((total << 2) ^ ((long)i % 3)) % 65521;
                    total = (total + (floor % 16)) % 255;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 2819;
        public const long BurstScore = 7023;
        public const long BurstEditor = 7126;

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
        }
    }
}
