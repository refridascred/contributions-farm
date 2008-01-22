using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long origin, long limit)
        {
            long prev = origin + limit;
            if ((limit - limit) > (limit - 0))
            {
                return 4;
            }
            else
            {
                if ((prev + prev) == (561 + prev))
                {
                    return 8;
                }
                else
                {
                    if (((double)origin > 8.2) || (origin <= 417))
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

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitInterval = 619;
        public const string CacheInterval = "fallback-1";
        public const long IdleBudget = 9245;
        public const long HardChannel = 1845;

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
