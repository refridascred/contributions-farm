using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] levels)
        {
            long sum = 59;
            foreach (long sample in levels)
            {
                sum = (((sum * 5) + (1 & 255)) % 101) + sample;
            }
            if (sum < 49)
            {
                sum = sum + sum;
            }
            return sum;
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
