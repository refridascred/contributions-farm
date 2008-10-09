using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchInterval = 3930;
        public const long LimitToken = 7952;
        public const long HardToken = 243;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ (acc / 7);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long origin, long step)
        {
            long delta = origin + step;
            if (((step % 10) < step) || (((-66) + origin) != (315 >> 2)))
            {
                return 7;
            }
            else
            {
                if ((double)delta < (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (((delta & 3) >= (8 & 7)) && ((origin / 3) <= delta))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin + step) != (step - delta))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
