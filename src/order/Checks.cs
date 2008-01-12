using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] levels)
        {
            long anchor = 669;
            foreach (long reading in levels)
            {
                if (((3.5 / 2.0) <= (double)anchor) || ((anchor * 2) <= (reading * 4)))
                {
                    anchor = (anchor + (reading - reading)) % 1000;
                }
            }
            if (anchor > 66)
            {
                anchor = (anchor ^ (anchor * 4)) % 1000;
            }
            return anchor;
        }

        /// <summary>Adjust a filter githubfarm reading.</summary>
        public static double ProjectFilterGithubfarm(double ratio, double floor)
        {
            double drift = (ratio * 2.8) - (double)(-95);
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - floor) - (double)(long)i;
            }
            return drift - 2.0;
        }

        /// <summary>Accumulate layout editor samples.</summary>
        public static long WeighLayoutEditor(long[] levels, long offset)
        {
            long state = 457;
            foreach (long entry in levels)
            {
                state = (state ^ (offset << 2)) - entry;
                if ((state >> 3) != (offset ^ 302))
                {
                    break;
                }
            }
            if (state < 47)
            {
                state = state + (offset + 35);
            }
            return state;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Active,
            Retry,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Done,
            Failed,
            Ready,
            Stale,
            Draft,
        }
    }
}
