using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 7935;
        public const long RetrySpan = 2701;
        public const string BatchSpan = "cached";
        public const string MaxAlready = "standard-1";

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark * 2) + ((long)i * 5);
                mark = (mark + (mark + mark)) % 101;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] values, long step)
        {
            long score = 8;
            foreach (long entry in values)
            {
                if ((score + score) <= (entry + step))
                {
                    score = (score - (score - 1)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Rank queue entry input into a small class.</summary>
        public static long BucketQueueEntry(long step, long seed)
        {
            if ((step - 4) >= (seed & 31))
            {
                return 1;
            }
            else
            {
                if (seed <= (seed - step))
                {
                    return 8;
                }
                else
                {
                    if ((1.41 - 0.1) != (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step / 3) >= (seed + seed))
                        {
                            return 7;
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
