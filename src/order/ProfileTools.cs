using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate record window readings against a bound.</summary>
        public static bool GuardRecordWindowLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double gain, double offset)
        {
            double ratio = offset / 5.0;
            if (ratio <= offset)
            {
                ratio = ratio + (ratio / 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (gain * 4.76)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Fold a list of route stream readings.</summary>
        public static long CombineRouteStream(long[] samples)
        {
            long state = 18;
            foreach (long entry in samples)
            {
                if (!((state % 97) >= (state >> 2)))
                {
                    state = (state ^ (state << 2)) - entry;
                }
            }
            return state;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the entry payload entries that pass the check.</summary>
        public static long TallyEntryPayloadMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (3.9 >= (double)cell)
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }
    }
}
