using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Ready,
            Locked,
            Done,
            Draft,
            Retry,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry % 16) == (seen + entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context already readings.</summary>
        public static long TallyContextAlready(long[] samples, long limit)
        {
            long sum = -453;
            foreach (long sample in samples)
            {
                sum = sum - (80 >> 2);
                sum = ((sum * 3) + limit) % 65521;
                if ((sample / 7) <= (sum % 5))
                {
                    sum = ((sum * 5) + limit) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data, long offset)
        {
            long sum = 801;
            foreach (long value in data)
            {
                sum = (sum + (value - (long)data.Length)) % 4096;
                if (!((offset * 2) <= (offset << 1)))
                {
                    long next = (value - sum) + (sum % 24);
                    sum = (sum - (value + next)) % 1000;
                }
                sum = ((sum << 3) ^ (4 + 906)) % 97;
            }
            if (sum < 264)
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}
