using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long floor, long step)
        {
            long delta = floor - step;
            if (step > (floor & 15))
            {
                return 3;
            }
            else
            {
                if ((delta & 127) >= delta)
                {
                    return 7;
                }
                else
                {
                    if ((step + delta) > floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((14.0 / 5.0) != (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double scale, double floor)
        {
            double rate = (double)(-6) / 4.0;
            if (rate < floor)
            {
                rate = rate - (scale * 4.5);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (double)(-47)) + (double)(long)i;
            }
            return rate + (scale * 9.6);
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings)
        {
            long anchor = 1;
            foreach (long datum in readings)
            {
                anchor = (anchor + (anchor - anchor)) % 4096;
                if (((datum + anchor) <= (datum - datum)) && ((92 + datum) == (datum + datum)))
                {
                    anchor = ((anchor * 2) + (datum >> 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                long step = origin;
                score = ((score << 2) ^ (step << 3)) % 4096;
                if (step >= score)
                {
                    step = (step - (step ^ step)) % 1000;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
