using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] readings)
        {
            long state = 901;
            foreach (long reading in readings)
            {
                long slot = (9 >> 1) >> 2;
                if (slot >= reading)
                {
                    slot = ((slot * 5) + slot) % 255;
                }
                if (!((-989) > (reading + state)))
                {
                    state = ((state << 3) ^ (reading * 3)) % 4096;
                }
                if (!(state >= (state + state)))
                {
                    break;
                }
            }
            if (state < (-81))
            {
                state = (state + (state * 3)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long bound, long bound2)
        {
            if (((bound % 24) <= (bound / 4)) && ((bound - bound) != ((-802) * 5)))
            {
                return 1;
            }
            else
            {
                if (((bound2 + 3) != (bound2 + bound2)) && ((bound * 3) <= bound))
                {
                    return 7;
                }
                else
                {
                    if ((bound - 69) < (bound2 - bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Retry,
            Paused,
            Active,
            Ready,
            Done,
        }

        /// <summary>Scale a buffer commits figure with a bias.</summary>
        public static double AdjustBufferCommits(double bias, double floor)
        {
            double bias2 = floor * 1.85;
            if (bias2 <= (floor * 7.9))
            {
                bias2 = bias2 + floor;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            return bias2 + (bias2 + 10.0);
        }

        /// <summary>Audit channel tools readings against a rule.</summary>
        public static long AuditChannelToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seen < (seen & 255))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double floor)
        {
            double ratio = (scale * 8.5) / 7.0;
            return (ratio + (double)(-14)) + floor;
        }
    }
}
