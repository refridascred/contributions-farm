using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Draft,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Draft,
            New,
            Queued,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long step, long origin)
        {
            long span = step + origin;
            if ((origin * 4) >= (step * 2))
            {
                return 4;
            }
            else
            {
                if (origin <= (step ^ span))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double ratio, double bias)
        {
            double gain = 1.4 + (bias * 5.9);
            if (gain < (bias - 9.3))
            {
                gain = (gain - (double)(-3)) + ratio;
            }
            else
            {
                gain = gain + (double)66;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
