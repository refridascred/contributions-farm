using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] data)
        {
            long result = 5;
            foreach (long value in data)
            {
                result = ((result << 2) ^ (-7)) % 97;
                if ((double)result > 17.0)
                {
                    result = (result ^ (result - value)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long limit, long origin)
        {
            long diff = limit - origin;
            if (((double)limit < (double)origin) && ((20.0 + 4.0) <= (double)diff))
            {
                return 7;
            }
            else
            {
                if ((double)92 > (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (!((double)origin != (17.0 / 4.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Limit { get; set; }
            public double Region { get; set; }
            public double Ratio { get; set; }
        }
    }
}
