using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 2291;
        public const double BurstInterval = 81.36;
        public const double DefaultWindow = 89.04;
        public const long StepCount = 653;

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] items)
        {
            long total = 2;
            foreach (long cell in items)
            {
                long prev = cell - (cell - cell);
                for (int i = 0; i < 9; i++)
                {
                    prev = prev + (cell + (long)i);
                    total = (total ^ ((long)i ^ prev)) % 1000;
                }
                if ((double)(-9) < (double)total)
                {
                    total = (total + (total & 7)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitDepth = 5707;
        public const string DefaultLevel = "fallback-v2";
        public const long SoftBatch = 5523;
        public const long BaseLevel = 8095;
    }
}
