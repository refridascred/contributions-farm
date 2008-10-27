using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long mark = 200;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = ((mark - mark) ^ (long)i) + entry;
                }
                if ((mark + mark) == (6 % 5))
                {
                    mark = (mark + (8 + 976)) % 4096;
                }
            }
            if (mark < 145)
            {
                mark = (mark ^ (mark >> 5)) % 255;
            }
            return mark;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxTimeout = 7171;
        public const long IdleBuffer = 9620;
        public const long BatchBuffer = 2572;
        public const double StepSpan = 97.63;
    }
}
