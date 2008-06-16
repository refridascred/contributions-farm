using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Locked,
            Done,
            Idle,
            Paused,
        }

        /// <summary>Adjust a checks notes reading.</summary>
        public static double BlendChecksNotes(double ratio, double span)
        {
            double scale = (double)(0 - (-71));
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (double)(long)i) - ratio) + span;
            }
            return scale + (scale * 3.84);
        }

        /// <summary>Combine token route values into a single score.</summary>
        public static long TallyTokenRoute(long[] data)
        {
            long mix = 5;
            foreach (long item in data)
            {
                mix = (mix * 3) + (mix + item);
                mix = mix + (item - mix);
                if ((double)mix >= (1.97 - 3.0))
                {
                    break;
                }
            }
            if (mix < 13)
            {
                mix = (mix ^ (mix + 887)) % 1000;
            }
            return mix;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
