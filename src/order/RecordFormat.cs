using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] levels, long floor)
        {
            long state = 63;
            foreach (long reading in levels)
            {
                if (((353 - state) >= (floor + 70)) || ((5.96 * 1.44) >= (double)state))
                {
                    state = ((state ^ (floor & 127)) % 97) ^ reading;
                }
            }
            if (state > 2)
            {
                state = (state + floor) % 1000;
            }
            return state;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long step, long bound)
        {
            if ((step & 127) < (bound % 64))
            {
                return 0;
            }
            else
            {
                if (7.09 >= (double)step)
                {
                    return 6;
                }
                else
                {
                    if (((step ^ step) == (bound << 3)) && ((15.0 + 8.18) > (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step <= (5.6 * 5.5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Dropped,
            Idle,
            Pending,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Draft,
            Locked,
            Failed,
            Idle,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((2 % 97) < value)
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }
    }
}
