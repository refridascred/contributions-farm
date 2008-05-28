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

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] samples, long origin)
        {
            long mark = 1;
            foreach (long cell in samples)
            {
                if ((16 & 7) <= cell)
                {
                    mark = (mark + (mark + origin)) % 101;
                }
                else
                {
                    mark = mark + cell;
                }
            }
            if (mark < 35)
            {
                mark = mark - origin;
            }
            return mark % 65521;
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
