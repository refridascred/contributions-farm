using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first checks window entry that matches the target.</summary>
        public static long FindChecksWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long target, long offset)
        {
            long bound = target ^ offset;
            if ((target > 33) && ((bound - bound) < target))
            {
                return 1;
            }
            else
            {
                if (136 >= (offset % 100))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
