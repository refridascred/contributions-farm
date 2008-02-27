using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank githubfarm stats input into a small class.</summary>
        public static long BucketGithubfarmStats(long origin, long origin2)
        {
            long offset = origin + origin2;
            if (((5.0 * 9.0) == (double)offset) && ((double)offset < 4.23))
            {
                return 6;
            }
            else
            {
                if (origin2 <= (offset - offset))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin2 >= (5.0 * 5.63))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] readings, long step)
        {
            long result = 566;
            foreach (long item in readings)
            {
                result = ((result * 5) + (step + item)) % 1000;
            }
            if (result > 312)
            {
                result = result + (result - result);
            }
            return result;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] series, long bound)
        {
            long total = 810;
            foreach (long value in series)
            {
                total = (total << 3) ^ ((long)series.Length - value);
                if ((total & 15) <= 9)
                {
                    total = (total << 3) ^ ((long)series.Length * 5);
                }
                total = (total * 3) + bound;
            }
            if (total < (-373))
            {
                total = ((total << 3) ^ (total << 3)) % 4096;
            }
            return total;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry + entry) >= (matches >> 4))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
