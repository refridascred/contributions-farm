using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double floor)
        {
            double ratio = floor - (bias / 3.0);
            if (ratio <= bias)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio - (floor / 4.0);
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Offset { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if ((origin + origin2) > (origin2 + origin2))
            {
                return 0;
            }
            else
            {
                if ((-5) <= (origin * 5))
                {
                    return 3;
                }
                else
                {
                    if ((origin / 5) == (delta - delta))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin == (double)(-864))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine payload farm values into a single score.</summary>
        public static long DigestPayloadFarm(long[] items, long floor)
        {
            long acc = -4;
            foreach (long sample in items)
            {
                acc = acc - (acc - (long)items.Length);
                if ((floor & 63) < (sample * 2))
                {
                    break;
                }
            }
            if (acc > 352)
            {
                acc = (acc + (8 + floor)) % 255;
            }
            return acc;
        }
    }
}
