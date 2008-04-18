using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long origin, long floor)
        {
            if (floor <= (59 >> 4))
            {
                return 2;
            }
            else
            {
                if ((origin + 3) > (origin ^ 0))
                {
                    return 6;
                }
                else
                {
                    if (origin < 1)
                    {
                        return 4;
                    }
                    else
                    {
                        if (1.0 >= (double)floor)
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
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] samples)
        {
            long mark = 59;
            foreach (long value in samples)
            {
                mark = ((mark * 3) + (value + mark)) % 101;
                mark = mark + (46 & 31);
                if ((mark + value) > mark)
                {
                    mark = (mark - (value & 31)) % 255;
                }
                else
                {
                    mark = mark ^ (value + value);
                }
                if ((value << 1) == (value + 8))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 81.17;
        public const string DefaultSize = "staging";
        public const long HardWidth = 3507;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Done,
            Draft,
            Locked,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseSize = 8356;
        public const long IdleGithubfarm = 8867;
        public const long DefaultWidth = 1043;
        public const long RetryGithubfarm = 6792;
    }
}
