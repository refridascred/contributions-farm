using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix << 2) ^ (origin >> 5)) % 65521;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleCommits = 3.64;
        public const long IdleBudget = 4276;
        public const double WindowFactor = 48.21;
        public const double RetryWidth = 63.27;

        /// <summary>Look up the position of a schema profile sample.</summary>
        public static long LocateSchemaProfileIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up token entry samples.</summary>
        public static long CompareTokenEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
