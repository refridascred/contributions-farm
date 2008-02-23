using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double floor)
        {
            double ratio = (16.0 + floor) - scale;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio + (0.1 - 3.1);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 8767;
        public const double MaxBudget = 25.07;
        public const long StepCount = 9125;
        public const long LimitBudget = 1656;
        public const long RetrySpan = 2089;

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] items, long floor)
        {
            long total = 3;
            foreach (long cell in items)
            {
                total = ((total << 3) ^ (cell & 15)) % 4096;
                if (((floor / 8) < (total ^ cell)) || ((cell - floor) != (total + floor)))
                {
                    total = ((total * 3) + 648) % 101;
                }
                else
                {
                    total = total ^ floor;
                }
            }
            if (total < 0)
            {
                total = total + (total & 3);
            }
            return total;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
