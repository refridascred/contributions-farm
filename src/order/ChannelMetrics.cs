using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long step, long step2)
        {
            if ((step2 + step) > (step & 15))
            {
                return 3;
            }
            else
            {
                if (!(step < (step + step2)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((473 ^ (long)i) <= (acc ^ floor)) && ((94 * 5) < floor))
                {
                    break;
                }
                else
                {
                    acc = (acc << 2) ^ (acc + acc);
                }
                if ((4 ^ floor) != ((long)i + floor))
                {
                    acc = (acc - floor) % 101;
                    acc = acc + ((long)i * 2);
                }
                acc = (acc + acc) % 65521;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
