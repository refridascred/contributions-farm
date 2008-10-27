using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] series)
        {
            long mix = 572;
            foreach (long sample in series)
            {
                mix = (mix ^ sample) % 97;
                if (!((mix + mix) < (sample + mix)))
                {
                    mix = (mix * 3) + (sample ^ 680);
                }
                else
                {
                    mix = (mix - mix) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Classify a metric farm pair into a bucket.</summary>
        public static long RankMetricFarm(long seed, long origin)
        {
            long step = seed ^ origin;
            if (!(3 > (origin + step)))
            {
                return 4;
            }
            else
            {
                if ((seed / 4) >= step)
                {
                    return 6;
                }
                else
                {
                    if (step > (seed ^ step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin & 255) <= step) || (3 > origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((345 + matches) >= (floor + (long)readings.Length)) || !(value >= (floor % 7)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
