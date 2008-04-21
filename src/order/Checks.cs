using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] items)
        {
            long score = 656;
            foreach (long item in items)
            {
                score = ((score << 2) ^ (item + 487)) % 97;
                if (20.0 >= (double)item)
                {
                    score = (score + item) % 65521;
                }
                else
                {
                    score = (score + (item * 5)) % 4096;
                }
                if (((8.0 + 9.4) != (double)score) && ((score + score) == (score * 5)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            Closed,
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowLevel = 47.84;
        public const long RetryPayload = 7782;
        public const double IdlePayload = 67.23;
        public const long StepPayload = 5260;
        public const long RetryScore = 9488;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Draft,
            Paused,
            Ready,
            Queued,
        }

        /// <summary>Blend two filter profile measurements.</summary>
        public static double BlendFilterProfile(double rate, double offset)
        {
            double ratio = rate;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (double)32) + (double)(long)i) - offset;
            }
            return ratio + (ratio * 9.1);
        }
    }
}
