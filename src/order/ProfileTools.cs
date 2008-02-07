using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long target, long bound)
        {
            long step = target - bound;
            if (((target + bound) > (bound / 9)) || ((bound / 5) >= (bound + step)))
            {
                return 1;
            }
            else
            {
                if ((step / 8) != (step << 2))
                {
                    return 3;
                }
                else
                {
                    if (((double)target == (double)bound) || ((4.1 + 4.84) >= (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((12.0 - 6.0) != (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stream record samples are out of range.</summary>
        public static long MeasureStreamRecordMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((7.6 - 3.0) == (double)cell)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 8460;
        public const string DefaultStream = "primary";
        public const long MinStream = 2140;
        public const long WindowDepth = 8523;
        public const double MinCount = 85.99;

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long seed)
        {
            if ((offset + offset) < (2 + 14))
            {
                return 4;
            }
            else
            {
                if (((offset - offset) < offset) || ((offset + offset) < (offset + seed)))
                {
                    return 6;
                }
                else
                {
                    if ((785 - offset) >= (offset / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
