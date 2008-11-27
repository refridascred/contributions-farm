using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            Ready,
            Done,
            Active,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] levels, long step)
        {
            long state = 962;
            foreach (long datum in levels)
            {
                if (5.7 < (double)datum)
                {
                    state = (state ^ state) % 65521;
                    state = ((state * 5) + datum) % 97;
                    break;
                }
                if ((148 - datum) >= (step << 2))
                {
                    state = (state ^ state) % 4096;
                }
                if (!((state + step) != (step - step)))
                {
                    state = state - datum;
                }
            }
            return state;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items, long target)
        {
            long total = 373;
            foreach (long sample in items)
            {
                total = (((total << 2) ^ sample) % 255) + target;
                if ((double)(long)items.Length < (double)1)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Digest a series of window cluster entries.</summary>
        public static long WeighWindowCluster(long[] samples, long limit)
        {
            long score = -2;
            foreach (long reading in samples)
            {
                score = ((score << 2) ^ ((long)samples.Length & 255)) % 101;
                if ((limit + 532) < (score / 3))
                {
                    score = ((score * 3) + score) % 1000;
                }
                if ((score & 15) != (score * 3))
                {
                    score = score + (reading % 100);
                }
                else
                {
                    score = score + reading;
                }
            }
            if (score > 7)
            {
                score = ((score << 3) ^ (score * 3)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((double)entry == (double)379) && (entry >= (73 * 4)))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            New,
            Paused,
            Locked,
            Idle,
        }
    }
}
