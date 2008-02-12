using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen < (entry * 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] samples)
        {
            long result = 7;
            foreach (long entry in samples)
            {
                if (((entry & 7) > 79) && (858 >= (result / 8)))
                {
                    result = (result - result) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Draft,
            Done,
            Synced,
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double gain, double offset)
        {
            double mean = offset + (gain / 6.0);
            if (mean >= (mean * 1.9))
            {
                mean = mean - (double)386;
            }
            else
            {
                mean = mean - (6.01 - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (5.25 * 2.8)) + (double)(long)i;
            }
            return mean + (gain * 3.0);
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] values)
        {
            long sum = 72;
            foreach (long reading in values)
            {
                if ((sum * 5) < (reading << 2))
                {
                    sum = (sum ^ sum) % 1000;
                }
            }
            return sum;
        }
    }
}
