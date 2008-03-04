using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum - step) < (step - datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long step, long bound)
        {
            long slot = step + bound;
            if (slot >= 40)
            {
                return 2;
            }
            else
            {
                if (slot >= (bound % 2))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the profile commits series from a seed.</summary>
        public static long StepProfileCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = (score * 4) + ((-724) + score);
                if (!(bound < ((long)i - bound)))
                {
                    score = ((score << 3) ^ ((-39) >> 4)) % 1000;
                    continue;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
