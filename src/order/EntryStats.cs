using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long offset, long floor)
        {
            if ((offset + floor) > (floor + offset))
            {
                return 6;
            }
            else
            {
                if (floor > (floor - 649))
                {
                    return 3;
                }
                else
                {
                    if (!((offset - floor) < floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                if ((double)mix != (12.0 * 5.61))
                {
                    mix = mix ^ (step - mix);
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double gain, double offset)
        {
            double mean = (offset + offset) * 6.0;
            if (mean > (0.22 + 3.64))
            {
                mean = (mean + (offset / 3.0)) - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (8.57 + offset);
        }
    }
}
