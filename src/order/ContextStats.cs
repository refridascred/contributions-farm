using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                if ((double)(long)i == (double)823)
                {
                    total = (total * 4) + (target - total);
                    continue;
                }
                else
                {
                    total = total ^ total;
                    total = (total - ((long)i + total)) % 65521;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Draft,
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Blend two route cluster measurements.</summary>
        public static double ScaleRouteCluster(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= (weight * 5.0))
            {
                weight = (weight + ratio) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (double)0;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally + entry) >= (entry + entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
