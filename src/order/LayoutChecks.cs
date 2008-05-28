using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long step)
        {
            if ((5 + step) > 2)
            {
                return 1;
            }
            else
            {
                if ((floor + step) == (floor << 3))
                {
                    return 3;
                }
                else
                {
                    if (!((step % 8) >= (step / 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)floor != (19.0 * 4.4)) && (step <= (step % 60)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] readings)
        {
            long mix = 6;
            foreach (long value in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix + (mix ^ value)) % 1000) + (long)i;
                }
                mix = mix - (value << 3);
                if ((mix * 4) < (value ^ value))
                {
                    break;
                }
            }
            if (mix > 3)
            {
                mix = (mix ^ mix) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum << 3) ^ 750) % 4096;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
