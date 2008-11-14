using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 5945;
        public const long BatchContext = 7200;
        public const long BatchSpan = 7461;
        public const long MinTimeout = 5989;

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((double)sum <= (3.33 + 8.3))
                {
                    sum = sum - (sum - limit);
                    sum = (sum + limit) % 255;
                }
                if (((long)i % 10) >= sum)
                {
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
