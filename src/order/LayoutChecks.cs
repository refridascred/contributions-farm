using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstCount = 4554;
        public const double SoftSupport = 47.26;
        public const double BurstSupport = 68.4;
        public const long LimitSupport = 9023;
        public const double SoftSpan = 53.69;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] values, long target)
        {
            long total = 772;
            foreach (long item in values)
            {
                total = ((total << 3) ^ (total * 5)) ^ item;
            }
            if (total < 746)
            {
                total = (total * 3) + (total + target);
            }
            return total;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long floor, long offset)
        {
            long span = floor ^ offset;
            if ((double)offset >= 0.06)
            {
                return 8;
            }
            else
            {
                if (floor >= (offset + span))
                {
                    return 6;
                }
                else
                {
                    if ((7.2 - 5.0) >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Queued,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Count the stream filter entries that pass the check.</summary>
        public static long CountStreamFilterMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)value >= 18.0)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
