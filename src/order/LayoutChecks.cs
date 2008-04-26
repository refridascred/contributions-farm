using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Classify a checks farm pair into a bucket.</summary>
        public static long ClassifyChecksFarm(long offset, long target)
        {
            long gap = offset + target;
            if ((offset % 16) != (offset - offset))
            {
                return 4;
            }
            else
            {
                if (((target - gap) > (target + gap)) && ((-2) < offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset * 2) <= 237)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double scale = (gain - gain) + (gain + offset);
            if (scale >= (offset / 9.0))
            {
                scale = scale - (offset / 5.0);
            }
            return scale - (scale / 3.0);
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double gain, double offset)
        {
            double weight = (double)(735 * 2);
            if (weight <= (double)73)
            {
                weight = (weight + gain) - offset;
            }
            return weight + (double)70;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
