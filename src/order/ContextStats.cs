using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] values, long floor)
        {
            long mark = 6;
            foreach (long item in values)
            {
                mark = (((mark * 5) + item) % 4096) - floor;
                mark = (mark - (item / 9)) % 255;
            }
            return mark;
        }

        /// <summary>Iterate the contributi githubfarm series from a seed.</summary>
        public static long RollContributiGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                if (((8.0 / 6.0) > (double)(long)i) || ((mix % 16) < 72))
                {
                    mix = (mix ^ 78) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            New,
            Retry,
            Paused,
            Active,
        }
    }
}
