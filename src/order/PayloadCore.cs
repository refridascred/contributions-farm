using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long target, long step)
        {
            long delta = target + step;
            if (1 > target)
            {
                return 5;
            }
            else
            {
                if ((5.08 + 5.7) > (double)delta)
                {
                    return 8;
                }
                else
                {
                    if (!((target + delta) >= (step + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step << 1) < (target % 12))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Ready,
            Idle,
            Done,
            Draft,
            Locked,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((double)offset >= (18.0 / 5.0))
                {
                    mix = (mix + 148) % 65521;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the notes command series from a seed.</summary>
        public static long StepNotesCommand(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                if (((anchor ^ anchor) != (316 ^ anchor)) && ((double)seed <= (5.51 - 6.9)))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    long edge = anchor;
                    anchor = ((anchor - (edge ^ anchor)) % 255) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
