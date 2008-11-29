using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] samples, long limit)
        {
            long sum = 714;
            foreach (long value in samples)
            {
                sum = (sum + (sum + (long)samples.Length)) % 1000;
                if (((double)value != (4.2 * 7.0)) || ((value / 9) <= (sum - sum)))
                {
                    sum = sum + (limit + limit);
                }
                else
                {
                    sum = (sum << 2) ^ (value ^ sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value >= (hits % 60))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long seed, long floor)
        {
            long prev = seed - floor;
            if (!(3 > (floor % 8)))
            {
                return 5;
            }
            else
            {
                if ((((-589) - prev) > (seed + seed)) && ((prev - floor) == (prev + seed)))
                {
                    return 0;
                }
                else
                {
                    if ((floor <= (prev / 2)) || ((floor << 3) < (floor % 60)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ offset) > (datum << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            Queued,
            Active,
            Paused,
            Done,
        }
    }
}
