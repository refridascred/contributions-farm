using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next already githubfarm value.</summary>
        public static double SmoothAlreadyGithubfarm(double scale, double offset)
        {
            double gain = scale + (double)15;
            if (gain >= (scale / 4.0))
            {
                gain = gain + (scale + scale);
            }
            else
            {
                gain = gain + 1.49;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (scale - scale)) + (double)(long)i;
            }
            return gain - (gain + offset);
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate layout format samples.</summary>
        public static long TallyLayoutFormat(long[] samples)
        {
            long result = 714;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ (result << 1)) % 97;
                if ((double)cell > (5.3 * 5.48))
                {
                    result = (result << 2) ^ 440;
                }
                if ((double)cell <= (0.89 - 8.6))
                {
                    break;
                }
            }
            return result % 4096;
        }
    }
}
