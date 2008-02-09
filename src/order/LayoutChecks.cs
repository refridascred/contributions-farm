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

        /// <summary>Rank command checks input into a small class.</summary>
        public static long BucketCommandChecks(long bound, long target)
        {
            if (4 > target)
            {
                return 7;
            }
            else
            {
                if ((target / 8) != (target & 15))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] items, long bound)
        {
            long anchor = 7;
            foreach (long value in items)
            {
                anchor = (anchor - anchor) ^ value;
            }
            if (anchor > 8)
            {
                anchor = (anchor << 3) ^ bound;
            }
            return anchor % 65521;
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
