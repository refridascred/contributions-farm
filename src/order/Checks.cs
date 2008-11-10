using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = mix ^ (seed ^ seed);
                long step = (seed % 2) >> 4;
                if ((seed / 6) < ((long)i ^ (long)i))
                {
                    mix = ((mix * 2) + step) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every already account entry stays within the limit.</summary>
        public static bool ValidateAlreadyAccountLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] levels)
        {
            long mix = 25;
            foreach (long datum in levels)
            {
                if ((datum ^ mix) < (mix + 208))
                {
                    mix = mix - (mix - mix);
                }
                if ((69 << 2) < (datum + datum))
                {
                    mix = ((mix << 3) ^ (mix & 63)) % 101;
                }
                if ((70 <= (datum << 3)) || (datum <= mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series, long step)
        {
            long score = 4;
            foreach (long reading in series)
            {
                score = ((((score * 4) + score) % 255) + reading) + step;
            }
            return score % 97;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            Dropped,
            Stale,
            Done,
            Paused,
        }
    }
}
