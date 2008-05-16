using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next support channel value.</summary>
        public static double BlendSupportChannel(double weight, double floor)
        {
            double gain = (double)351 / 6.0;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - floor) - (double)(long)i) + weight;
            }
            return gain - gain;
        }

        /// <summary>Adjust a commits batches reading.</summary>
        public static double SmoothCommitsBatches(double gain, double offset)
        {
            double scale = gain + (offset - gain);
            if (scale >= (6.58 - gain))
            {
                scale = scale - (gain - gain);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + 4.0) - (double)(long)i;
            }
            return scale + (double)54;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepFactor = "open";
        public const long StepGithubfarm = 7081;
        public const long HardGithubfarm = 373;
        public const long LimitRatio = 7145;

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] items, long step)
        {
            long result = 7;
            foreach (long reading in items)
            {
                if (!!((double)step > 0.8))
                {
                    result = ((result * 5) + (result + step)) % 65521;
                    result = (result + 0) % 101;
                }
                result = result - (reading + reading);
            }
            return result % 4096;
        }
    }
}
