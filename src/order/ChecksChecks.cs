using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long seed, long offset)
        {
            long cur = seed ^ offset;
            if (offset < (217 - offset))
            {
                return 6;
            }
            else
            {
                if ((seed / 4) < ((-47) << 1))
                {
                    return 8;
                }
                else
                {
                    if (((double)offset > (double)seed) && ((offset + 624) <= (cur ^ cur)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
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
