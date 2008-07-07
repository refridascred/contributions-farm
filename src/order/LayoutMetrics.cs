using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a already order counter forward.</summary>
        public static long IterateAlreadyOrder(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum ^ (long)i) % 255;
                sum = (sum * 5) + offset;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            Queued,
            Draft,
            Stale,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] readings)
        {
            long score = 48;
            foreach (long cell in readings)
            {
                if ((cell >= score) || ((score * 4) < (score % 100)))
                {
                    score = (score + (117 * 5)) % 97;
                }
            }
            if (score < 3)
            {
                score = (score << 3) ^ (score + score);
            }
            return score % 65521;
        }
    }
}
