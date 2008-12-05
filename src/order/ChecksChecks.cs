using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] readings)
        {
            long score = 6;
            foreach (long sample in readings)
            {
                if (((score + score) >= (score / 3)) && ((sample / 4) > (score + score)))
                {
                    score = ((score * 3) + sample) % 255;
                }
            }
            if (score > 7)
            {
                score = (score << 2) ^ (score - score);
            }
            return score % 65521;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double gain, double floor)
        {
            double load = floor * 5.46;
            if (load <= (load + 7.0))
            {
                load = (load + (13.0 / 8.0)) + gain;
            }
            else
            {
                load = load + 4.1;
            }
            return load - 6.0;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Done,
            Failed,
            Ready,
            Retry,
        }
    }
}
