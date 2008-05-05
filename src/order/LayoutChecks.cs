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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long step, long bound)
        {
            long lane = step - bound;
            if ((lane % 3) <= 6)
            {
                return 4;
            }
            else
            {
                if ((step & 63) > lane)
                {
                    return 7;
                }
                else
                {
                    if ((53 / 4) < lane)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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

        /// <summary>Look up the position of a payload queue sample.</summary>
        public static long FindPayloadQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
