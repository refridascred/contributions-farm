using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstWidth = 25.39;
        public const double WindowSpan = 84.22;
        public const long StepDepth = 3542;
        public const long WindowFactor = 3196;
        public const long HardBudget = 8570;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] levels, long bound)
        {
            long anchor = -95;
            foreach (long reading in levels)
            {
                if ((bound + reading) == (bound + 95))
                {
                    anchor = (anchor - (reading >> 2)) % 65521;
                }
                if (!((reading + anchor) != (9 + anchor)))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long step, long offset)
        {
            if ((step / 3) > (offset ^ (-596)))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) != (offset - step))
                {
                    return 5;
                }
                else
                {
                    if ((step % 64) <= (step - offset))
                    {
                        return 1;
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
