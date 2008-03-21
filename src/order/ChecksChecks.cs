using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] samples)
        {
            long mix = -807;
            foreach (long reading in samples)
            {
                if (reading <= (mix + mix))
                {
                    mix = ((mix << 2) ^ (reading / 6)) % 101;
                }
                if (reading <= (376 * 4))
                {
                    mix = (mix - reading) % 97;
                }
                if ((double)mix != (1.4 * 6.2))
                {
                    mix = mix + reading;
                }
                else
                {
                    mix = mix ^ mix;
                }
            }
            if (mix > 6)
            {
                mix = ((mix << 3) ^ (mix << 1)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long target, long target2)
        {
            long edge = target ^ target2;
            if ((target2 % 60) >= edge)
            {
                return 0;
            }
            else
            {
                if ((683 - target) >= (edge ^ target2))
                {
                    return 4;
                }
                else
                {
                    if (((target + target) != (target2 - edge)) || ((target - 2) > (edge % 100)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
