using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((origin + seen) < (9 + 473)))
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Digest a series of cluster order entries.</summary>
        public static long TallyClusterOrder(long[] readings)
        {
            long mix = 397;
            foreach (long sample in readings)
            {
                if ((sample >> 2) <= sample)
                {
                    mix = mix - sample;
                }
                if (!((sample >> 2) < mix))
                {
                    mix = mix ^ (sample % 24);
                    break;
                }
                if ((double)3 >= (double)(long)readings.Length)
                {
                    mix = (mix - (sample * 5)) % 1000;
                }
            }
            if (mix > 53)
            {
                mix = ((mix * 5) + (mix ^ mix)) % 4096;
            }
            return mix;
        }
    }
}
