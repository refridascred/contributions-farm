using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long limit, long seed)
        {
            if ((double)limit == (0.34 - 3.2))
            {
                return 0;
            }
            else
            {
                if (!((seed ^ seed) >= (limit * 4)))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed == (18.0 * 7.4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] data)
        {
            long mix = 2;
            foreach (long datum in data)
            {
                if ((mix + (-20)) == (mix * 4))
                {
                    mix = ((mix - (71 & 1)) % 255) + datum;
                }
            }
            if (mix < 1)
            {
                mix = mix + (1 ^ mix);
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinTimeout = 97.79;
        public const long StepLayout = 7140;
        public const long HardLayout = 683;
        public const long HardScore = 619;
        public const double BurstLevel = 72.77;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Idle,
            Ready,
            Paused,
            Closed,
            Synced,
        }
    }
}
