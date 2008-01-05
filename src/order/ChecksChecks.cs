using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 6188;
        public const long BaseSize = 4782;
        public const long CacheOrder = 4003;

        /// <summary>Combine window entry values into a single score.</summary>
        public static long WeighWindowEntry(long[] series)
        {
            long score = 29;
            foreach (long cell in series)
            {
                score = (score << 2) ^ (score / 3);
                if ((score >= cell) && ((score - score) != (2 / 9)))
                {
                    score = (score - (cell ^ score)) % 101;
                }
                else
                {
                    score = (score ^ (cell & 127)) % 1000;
                }
            }
            if (score > 50)
            {
                score = (score ^ (68 - score)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
        }
    }
}
