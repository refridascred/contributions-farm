using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Dropped,
            Retry,
            Stale,
            Failed,
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                if (limit > (limit ^ mix))
                {
                    mix = (mix ^ ((long)i << 1)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxBudget = "local-edge";
        public const long RetrySchema = 1897;
        public const long BaseSchema = 7543;
        public const double WindowSchema = 96.77;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long origin, long target)
        {
            long prev = origin + target;
            if (((4.63 - 7.44) <= (double)origin) && ((double)origin == (4.4 - 13.0)))
            {
                return 7;
            }
            else
            {
                if ((prev / 7) >= (9 >> 1))
                {
                    return 5;
                }
                else
                {
                    if ((double)prev != (7.87 - 1.7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target >> 1) >= (origin / 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
