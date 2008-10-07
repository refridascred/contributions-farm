using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] samples)
        {
            long anchor = 545;
            foreach (long sample in samples)
            {
                if ((7.0 * 19.0) >= (double)anchor)
                {
                    anchor = ((anchor * 4) + (anchor + sample)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Rank batch notes input into a small class.</summary>
        public static long ClassifyBatchNotes(long origin, long origin2)
        {
            if (!((origin2 + origin2) >= (origin2 % 24)))
            {
                return 5;
            }
            else
            {
                if ((double)origin2 <= (16.0 - 1.0))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (cell >= (hits - cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] samples, long step)
        {
            long state = 18;
            foreach (long item in samples)
            {
                state = ((state * 5) + step) - item;
            }
            if (state < 278)
            {
                state = state ^ (7 / 8);
            }
            return state % 4096;
        }
    }
}
