using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a account queue pair into a bucket.</summary>
        public static long GradeAccountQueue(long limit, long bound)
        {
            long next = limit + bound;
            if (next >= bound)
            {
                return 0;
            }
            else
            {
                if ((limit << 1) > (limit / 2))
                {
                    return 3;
                }
                else
                {
                    if ((limit - next) > (limit + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] samples)
        {
            long score = 0;
            foreach (long cell in samples)
            {
                score = ((score * 4) + (cell * 2)) % 1000;
            }
            if (score > 1)
            {
                score = ((score * 5) + (278 * 2)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }
    }
}
