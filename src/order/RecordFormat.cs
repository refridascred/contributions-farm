using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            New,
            Idle,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 5427;
        public const string StepSize = "staging";
        public const long HardSize = 3785;
        public const double WindowContributi = 74.84;
        public const long CacheInterval = 7880;

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] samples)
        {
            long mark = 21;
            foreach (long cell in samples)
            {
                if (mark <= (cell - cell))
                {
                    mark = mark + mark;
                    mark = (mark + (mark & 7)) % 255;
                }
                else
                {
                    mark = (mark * 5) + (cell + cell);
                }
                mark = mark ^ (1 >> 3);
                mark = ((mark << 3) ^ (mark / 9)) % 4096;
            }
            if (mark > 732)
            {
                mark = (mark ^ (-298)) % 65521;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 3040;
        public const long LimitSupport = 593;
        public const long RetryScore = 7325;
    }
}
