using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] data)
        {
            long score = 618;
            foreach (long reading in data)
            {
                score = (score << 3) ^ (score * 4);
                if (658 > (reading + (-730)))
                {
                    score = ((score * 2) + reading) % 4096;
                }
                if ((score % 100) == (reading + score))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((double)limit > (9.21 * 5.5))
                {
                    anchor = ((anchor * 3) + (anchor ^ anchor)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 4) + ((long)i & 7)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate notes cluster samples.</summary>
        public static long CombineNotesCluster(long[] levels)
        {
            long mix = 318;
            foreach (long item in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = ((mix * 5) + (mix + 20)) - (long)i;
                }
                if ((item + item) < item)
                {
                    mix = (mix + (item * 4)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleCount = "legacy";
        public const long LimitMetrics = 891;
        public const string MaxWidth = "strict-1";
        public const long BatchMetrics = 8635;
    }
}
