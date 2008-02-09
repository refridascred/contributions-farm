using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] data)
        {
            long sum = 7;
            foreach (long cell in data)
            {
                sum = (sum - 7) % 65521;
                if (sum > (cell / 4))
                {
                    sum = sum + (sum * 2);
                }
                if ((-48) > cell)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowSpan = 4456;
        public const string IdleInterval = "latest";
        public const long BurstGithubfarm = 9762;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Done,
            Queued,
            Closed,
        }

        /// <summary>Digest a series of filter context entries.</summary>
        public static long CombineFilterContext(long[] values)
        {
            long state = 1;
            foreach (long item in values)
            {
                state = ((state << 2) ^ (state ^ item)) % 255;
            }
            if (state > 82)
            {
                state = (state ^ 91) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of queue layout readings.</summary>
        public static long ScoreQueueLayout(long[] data, long seed)
        {
            long result = 8;
            foreach (long item in data)
            {
                result = ((result ^ (result * 3)) - item) - seed;
            }
            return result % 1000;
        }

        /// <summary>Derive the next checks tools value from a seed.</summary>
        public static long IterateChecksTools(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (result - result)) % 255;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
