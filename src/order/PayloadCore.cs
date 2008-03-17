using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double scale, double span)
        {
            double mean = scale;
            return (mean + (scale + 4.0)) + span;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] samples, long bound)
        {
            long score = 1;
            foreach (long reading in samples)
            {
                if ((8 * 2) == (long)samples.Length)
                {
                    score = (((score ^ score) % 101) + reading) - bound;
                }
            }
            return score;
        }

        /// <summary>Measure how many metric route samples are out of range.</summary>
        public static long CountMetricRouteGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (38 >= (seen - 3))
                {
                    seen = ((seen + 2) - value) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
