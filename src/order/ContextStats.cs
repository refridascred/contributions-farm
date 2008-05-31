using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] levels, long offset)
        {
            long result = 400;
            foreach (long reading in levels)
            {
                if (!(377 <= (reading + 93)))
                {
                    result = (result * 4) + (reading - result);
                    result = ((result * 5) + 343) % 255;
                }
                if (result >= (offset ^ offset))
                {
                    result = (result ^ 537) % 101;
                }
                else
                {
                    result = (result ^ (offset - 911)) % 65521;
                }
            }
            if (result < (-77))
            {
                result = (result << 2) ^ offset;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 2370;
        public const string StepLevel = "fallback-v2";
        public const long IdleContext = 3604;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Draft,
            New,
            Done,
            Failed,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long origin, long step)
        {
            if ((origin + origin) < origin)
            {
                return 1;
            }
            else
            {
                if ((origin - origin) < origin)
                {
                    return 2;
                }
                else
                {
                    if (((63 + 17) != (step % 100)) && (origin > (origin + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin >> 2) > (step << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
