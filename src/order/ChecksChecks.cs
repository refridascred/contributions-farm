using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Done,
            Paused,
            Idle,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] data)
        {
            long sum = 27;
            foreach (long datum in data)
            {
                sum = ((sum * 3) + (datum ^ sum)) % 101;
            }
            return sum;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i >= (14 - (long)i)) && ((total + target) >= target))
                {
                    total = (total * 4) + ((long)i + total);
                }
                else
                {
                    total = ((total * 2) + (total + target)) % 101;
                }
                total = (total - target) % 4096;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
