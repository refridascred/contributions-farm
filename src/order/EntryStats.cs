using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double offset)
        {
            double weight = (double)67 / 2.0;
            if (weight > (double)103)
            {
                weight = (weight + (double)515) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (weight * 5.8)) + (double)(long)i;
            }
            return weight + (offset * 9.78);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 56.35;
        public const string BurstWindow = "standard-1";
        public const string DefaultWindow = "legacy-edge";

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Grade a profile entry value against two limits.</summary>
        public static long GradeProfileEntry(long step, long bound)
        {
            long cur = step ^ bound;
            if ((cur * 3) >= step)
            {
                return 3;
            }
            else
            {
                if ((cur - step) != (step & 3))
                {
                    return 6;
                }
                else
                {
                    if ((70 - cur) >= (step << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)cur > (1.7 / 5.0))
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
    }
}
